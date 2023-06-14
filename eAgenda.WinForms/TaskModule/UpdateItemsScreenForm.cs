using eAgenda.Domain.TaskModule;

namespace eAgenda.WinForms.TaskModule
{
    public partial class UpdateItemsScreenForm : Form
    {
        public UpdateItemsScreenForm(Domain.TaskModule.Task task)
        {
            InitializeComponent();

            this.ConfigDialog();

            ConfigScreen(task);
        }

        private void ConfigScreen(Domain.TaskModule.Task task)
        {
            txtId.Text = task.id.ToString();

            txtTitle.Text = task.title;

            int i = 0;
            foreach (TaskItem item in task.items)
            {
                listItemsTaks.Items.Add(item);

                if(item.done) 
                    listItemsTaks.SetItemChecked(i, true);
                
                i++;
            }
        }

        public List<TaskItem> GetCheckItems()
        {
            return listItemsTaks.CheckedItems.Cast<TaskItem>().ToList();
        }

        public List<TaskItem> GetPendingItems()
        {
            return listItemsTaks.Items.Cast<TaskItem>()
                .Except(GetCheckItems())
                .ToList();
        }
    }
}
