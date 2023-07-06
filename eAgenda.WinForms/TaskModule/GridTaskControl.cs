namespace eAgenda.WinForms.TaskModule
{
    public partial class GridTaskControl : UserControl
    {
        public GridTaskControl()
        {
            InitializeComponent();

            gridTasks.ConfigGridColor();

            gridTasks.ConfigGridReadOnly();

            ConfigColumns();
        }

        public void ConfigColumns()
        {
            DataGridViewColumn[] columns = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "ID"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "title",
                    HeaderText = "TITLE"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "crationDate",
                    HeaderText = "CREATION DATE"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "priority",
                    HeaderText = "PRIORITY"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "percentCompleted",
                    HeaderText = "% COMPLETED"
                }
            };

            gridTasks.Columns.AddRange(columns);
        }

        public void UpdateList(List<Domain.TaskModule.Task> tasks)
        {
            gridTasks.Rows.Clear();

            foreach (Domain.TaskModule.Task task in tasks)
            {
                gridTasks.Rows.Add(task.id, task.title, task.creationDate.ToString("dd/MM/yyyy"), task.priority, task.percentCompleted.ToString("F0") + "%");
            }

            MainScreenForm.Instance.UpdateFooter($"Viewing {tasks.Count} tasks");
        }

        public int GetSelectedId()
        {
            if (gridTasks.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridTasks.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
