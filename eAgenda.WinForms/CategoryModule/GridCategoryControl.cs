using eAgenda.Domain.CategoryModule;

namespace eAgenda.WinForms.ExpenseModule
{
    public partial class GridCategoryControl : UserControl
    {
        public GridCategoryControl()
        {
            InitializeComponent();

            gridCategories.ConfigGridColor();
            gridCategories.ConfigGridReadOnly();

            ConfigColumns();
        }

        private void ConfigColumns()
        {
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "id";
            id.HeaderText = "ID";

            DataGridViewTextBoxColumn title = new DataGridViewTextBoxColumn();
            title.Name = "title";
            title.HeaderText = "TITLE";

            gridCategories.Columns.Add(id);
            gridCategories.Columns.Add(title);
        }

        public void UpdateList(List<Category> category)
        {
            gridCategories.Rows.Clear();

            foreach (Category c in category)
            {
                gridCategories.Rows.Add(c.id, c.title);
            }

            MainScreenForm.Instance.UpdateFooter($"Viewing {category.Count} categories");
        }

        public int GetSelectedId()
        {
            if (gridCategories.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridCategories.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
