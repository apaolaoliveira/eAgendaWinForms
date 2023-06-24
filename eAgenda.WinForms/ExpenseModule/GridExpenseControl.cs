using eAgenda.Domain.ExpenseModule;

namespace eAgenda.WinForms.ExpenseModule
{
    public partial class GridExpenseControl : UserControl
    {
        public GridExpenseControl()
        {
            InitializeComponent();

            gridExpenses.ConfigGridColor();
            gridExpenses.ConfigGridReadOnly();

            ConfigColumns();
        }

        private void ConfigColumns()
        {
            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn
                {
                    Name = "id",
                    HeaderText = "ID",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "description",
                    HeaderText = "DESCRIPTION",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "date",
                    HeaderText = "DATE",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "price",
                    HeaderText = "PRICE",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "pay",
                    HeaderText = "PAYMENT METHOD",
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "category",
                    HeaderText = "CATEGORY"
                }
            };

            gridExpenses.Columns.AddRange(columns);
        }

        public void UpdateList(List<Expense> expense)
        {
            gridExpenses.Rows.Clear();

            foreach (Expense e in expense)
            {
                gridExpenses.Rows.Add(e.id, e.description, e.date.ToShortDateString(), e.price.ToString("C"), e.paymentMethod, e.category);
            }

            MainScreenForm.Instance.UpdateFooter($"Viewing {expense.Count} expenses");
        }

        public int GetSelectedId()
        {
            if (gridExpenses.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridExpenses.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
