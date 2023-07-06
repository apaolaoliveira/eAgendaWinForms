using eAgenda.Domain.ContactModule;
using eAgenda.Domain.TaskModule;

namespace eAgenda.WinForms.TaskModule
{
    public class TaskController : ControllerBase
    {
        private ITaskRepository _taskRepository;
        private GridTaskControl _taskGrid;

        public TaskController(ITaskRepository repository)
        {
            _taskRepository = repository;
            MainScreenForm.Instance.UpdateLblFilter("");
        }

        public override string ToolTipAdd => "Add new Task";

        public override string ToolTipUpdate => "Edit Task";

        public override string ToolTipDelete => "Delete Task";

        public override string ToolTipFilter => "Filtrar Tarefas";

        public override string ToolTipAddItem => "Add items in a Task";

        public override string ToolTipCheckItem => "Check task's item";

        public override bool CheckItemEnable => true;

        public override bool AddItemEnable => true;

        public override bool FilterEnable => true;

        public override bool lblFilterVisible => true;

        public override void Add()
        {
            TaskScreenForm taskScreen = new TaskScreenForm(editTask: false);
            taskScreen.Text = "Add a new task";
            DialogResult selectedOption = taskScreen.ShowDialog();

            if (selectedOption == DialogResult.OK)
            {
                Domain.TaskModule.Task newTask = taskScreen.GetTask();
                _taskRepository.Add(newTask);
            }

            UploadTasks();
        }

        public override void Update()
        {
            Domain.TaskModule.Task selectedTask = GetSelectedTask();

            if (selectedTask == null)
            {
                MessageBox.Show("First, select a task!", "Delete Task", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TaskScreenForm screenTask = new TaskScreenForm(editTask: true);
            screenTask.Text = "Update selected task";
            screenTask.ConfigScreen(selectedTask);

            DialogResult selectedOption = screenTask.ShowDialog();

            if(selectedOption == DialogResult.OK)
            {
                Domain.TaskModule.Task task = screenTask.GetTask();
                _taskRepository.Update(task.id, task);
            }

            UploadTasks();
        }

        public override void Delete()
        {
            Domain.TaskModule.Task selectedTask = GetSelectedTask();

            if(selectedTask == null)
            {
                MessageBox.Show("First, select a task!", "Delete Task", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult selectedOption =
                MessageBox.Show($"Are you sure about deleting \"{selectedTask.title}\" from your list?",
                                "Delete Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (selectedOption == DialogResult.Yes)            
                _taskRepository.Delete(selectedTask);            

            UploadTasks();
        }

        public override void AddItem()
        {
            Domain.TaskModule.Task selectedTask = GetSelectedTask();

            if(selectedTask == null)
            {
                MessageBox.Show("First, select a task!", "Add item to Task", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            RecordItemsScreenForm recordItems = new RecordItemsScreenForm(selectedTask);
            recordItems.Text = "Add items to a task";
            DialogResult selectedOption = recordItems.ShowDialog();

            if(selectedOption == DialogResult.OK)
            {
                List<TaskItem> addItems = recordItems.GetRecordItems();

                foreach(TaskItem item in addItems)
                {
                    selectedTask.AddItem(item);
                }

                _taskRepository.Update(selectedTask.id, selectedTask);

                UploadTasks();
            }
        }

        public override void CheckItem()
        {
            Domain.TaskModule.Task selectedTask = GetSelectedTask();
            
            if (selectedTask == null)
            {
                MessageBox.Show("First, select a task!", "Check item from Task", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            UpdateItemsScreenForm updateItems = new UpdateItemsScreenForm(selectedTask);
            updateItems.Text = "Check a task's items";
            DialogResult selectedOption = updateItems.ShowDialog();

            if(selectedOption == DialogResult.OK)
            {
                List<TaskItem> CheckedItems = updateItems.GetCheckItems();
                
                List<TaskItem> PendingItems = updateItems.GetPendingItems();

                foreach (TaskItem item in CheckedItems)
                {
                    selectedTask.CheckItem(item);
                }

                foreach (TaskItem item in PendingItems)
                {
                    selectedTask.UncheckItem(item);
                }

                _taskRepository.Update(selectedTask.id, selectedTask);

                UploadTasks();
            }
        }

        public override void Filter()
        {
            FilterTaskScreenForm screenFilter = new FilterTaskScreenForm();
            screenFilter.Text = "Task's filter";
            DialogResult selectedOption = screenFilter.ShowDialog();

            if(selectedOption == DialogResult.OK)
            {
                List<Domain.TaskModule.Task> tasks;

                TaskStatusEnum status = screenFilter.GetTaskFilter();

                switch (status)
                {
                    case TaskStatusEnum.Pending: tasks = _taskRepository.SelectPending(); break;

                    case TaskStatusEnum.Done: tasks = _taskRepository.SelectDone(); break;

                    default: tasks = _taskRepository.SelectByPriorities(); break;   
                }

                UploadTasks(tasks); 
            }
        }

        public override UserControl GetList()
        {
            if (_taskGrid == null)
                _taskGrid = new GridTaskControl();

            UploadTasks();

            return _taskGrid;
        }

        public override string GetRegisterType()
        {
            return "Tasks' Records";
        }

        public Domain.TaskModule.Task GetSelectedTask()
        {
            int id = _taskGrid.GetSelectedId();

            return _taskRepository.SelectId(id);
        }

        private void UploadTasks(List<Domain.TaskModule.Task> tasks)
        {
            _taskGrid.UpdateList(tasks);
        }

        private void UploadTasks()
        {
            List<Domain.TaskModule.Task> tasks = _taskRepository.SelectByPriorities();

            _taskGrid.UpdateList(tasks);
        }
    }
}
