using eAgenda.Domain.TaskModule;

namespace eAgenda.WinForms.TaskModule
{
    public partial class RecordItemsScreenForm : Form
    {
        public RecordItemsScreenForm(Domain.TaskModule.Task task)
        {
            InitializeComponent();

            this.ConfigDialog();

            ConfigScreen(task);
        }

        private void ConfigScreen(Domain.TaskModule.Task task)
        {
            txtId.Text = task.id.ToString();

            txtTitle.Text = task.title;

            listItems.Items.AddRange(task.items.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtDescription.Text;

            if (string.IsNullOrWhiteSpace(title))
                return;

            TaskItem taskItem = new TaskItem(title);

            listItems.Items.Add(taskItem);

            txtDescription.Text = string.Empty;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listItems.SelectedItem == null)
            {
                MainScreenForm.Instance.UpdateFooter("First, select a value from the list.");
                return;
            }

            listItems.Items.Remove(listItems.SelectedItem);
        }

        public List<TaskItem> GetRecordItems()
        {            
            return listItems.Items.Cast<TaskItem>().ToList();
        }
    }
}
