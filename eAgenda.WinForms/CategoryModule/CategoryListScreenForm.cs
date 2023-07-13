using eAgenda.Domain.ExpenseModule;

namespace eAgenda.WinForms.ExpenseModule
{
    public partial class CategoryListScreenForm : Form
    {
        public CategoryListScreenForm()
        {
            InitializeComponent();
            this.ConfigDialog();
        }

        public void SetCategoryName(string selectedCategory)
        {
            lblCategory.Text = selectedCategory;
        }

        public void UploadRecords(List<Expense> expenses, decimal finalPrice)
        {
            list.UpdateList(expenses, finalPrice);
        }

        private void btnOK_MouseEnter(object sender, EventArgs e)
        {
            btnOK.BackColor = Color.FromArgb(45, 45, 45);
            btnOK.ForeColor = Color.FromArgb(250, 250, 250);
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.BackColor = SystemColors.Control;
            btnOK.ForeColor = Color.FromArgb(45, 45, 45);
        }
    }
}
