using eAgenda.Domain.TaskModule;

namespace eAgenda.WinForms.TaskModule
{
    public partial class TaskScreenForm : Form
    {
        public TaskScreenForm(bool editTask)
        {
            InitializeComponent();

            this.ConfigDialog();

            UploadPriority();

            if (editTask)
                txtCreationDate.Enabled = false;
        }

        private void UploadPriority()
        {
            TaskPriorityEnum[] priorities = Enum.GetValues<TaskPriorityEnum>();

            foreach (TaskPriorityEnum priority in priorities)
            {
                cmbPriority.Items.Add(priority);
            }
        }

        public Domain.TaskModule.Task GetTask()
        {
            int id = Convert.ToInt32(txtId.Text);

            string title = txtTitle.Text;

            TaskPriorityEnum priority = (TaskPriorityEnum)cmbPriority.SelectedItem;

            DateTime creationDate = txtCreationDate.Value;

            Domain.TaskModule.Task task = new Domain.TaskModule.Task(id, title, priority, creationDate);

            if (id > 0)
                task.id = id;

            return task;
        }

        public void ConfigScreen(Domain.TaskModule.Task selectedTask)
        {
            txtId.Text = selectedTask.id.ToString();

            txtTitle.Text = selectedTask.title;

            cmbPriority.SelectedItem = selectedTask.priority;

            txtCreationDate.Value = selectedTask.creationDate;
        }
    }
}
