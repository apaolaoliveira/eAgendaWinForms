using eAgenda.Domain.TaskModule;

namespace eAgenda.WinForms.TaskModule
{
    public partial class FilterTaskScreenForm : Form
    {
        public FilterTaskScreenForm()
        {
            InitializeComponent();
        }

        public void ConfigScreen()
        {
            string filterText = MainScreenForm.Instance.GetFilterText();

            if (filterText == "Filtering Done Tasks")
                rdbDone.Checked = true;

            else if (filterText == "Filtering Pending Tasks")
                rdbPending.Checked = true;

            else if (filterText == "Filtering All Tasks")
                rdbAll.Checked = true;
        }

        public TaskStatusEnum GetTaskFilter()
        {
            if (rdbDone.Checked == true)
            {
                MainScreenForm.Instance.UpdateLblFilter("Filtering Done Tasks");
                return TaskStatusEnum.Done;
            }

            else if (rdbPending.Checked == true)
            {
                MainScreenForm.Instance.UpdateLblFilter("Filtering Pending Tasks");
                return TaskStatusEnum.Pending;
            }

            MainScreenForm.Instance.UpdateLblFilter("Filtering All Tasks");
            return TaskStatusEnum.All;
        }
    }
}
