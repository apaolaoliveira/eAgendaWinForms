using eAgenda.Domain.ExpenseModule;
using System.Runtime.CompilerServices;

namespace eAgenda.WinForms.ExpenseModule
{
    public partial class CategoryListControl : UserControl
    {
        public CategoryListControl()
        {
            InitializeComponent();

            ConfigListView();
        }

        private void ConfigListView()
        {
            categoriesList.View = View.Details;
            categoriesList.HideSelection = true;
            categoriesList.FullRowSelect = false;
            categoriesList.LabelEdit = false;
            categoriesList.GridLines = true;

            Font font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoriesList.Font = font;

            _ = HorizontalAlignment.Left;
            categoriesList.BackColor = Color.Snow;
        }

        public void UpdateList(List<Expense> expenses, decimal finalPrice)
        {
            categoriesList.Items.Clear();

            categoriesList.Columns.Add("", 0);
            categoriesList.Columns.Add("ID", 95);
            categoriesList.Columns.Add("DESCRIPTION", 400);
            categoriesList.Columns.Add("PRICE", 300);

            foreach (Expense expense in expenses)
            {
                ListViewItem categoryItems = new ListViewItem();
                categoryItems.SubItems.Add(expense.id.ToString());
                categoryItems.SubItems.Add(expense.description);
                categoryItems.SubItems.Add(expense.price.ToString("C"));

                categoriesList.Items.Add(categoryItems);
            }

            ListViewItem finalItem = new ListViewItem("");
            finalItem.BackColor = Color.FromArgb(45, 45, 45);
            finalItem.ForeColor = Color.FromArgb(250, 250, 250);
            finalItem.SubItems.Add("");
            finalItem.SubItems.Add("FINAL PRICE: ");
            finalItem.SubItems.Add(finalPrice.ToString("C"));

            categoriesList.Items.Add(finalItem);
        }
    }
}
