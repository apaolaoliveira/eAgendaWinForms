using eAgenda.Domain.ExpenseModule;

namespace eAgenda.WinForms.ExpenseModule
{
    public partial class CategoryScreenForm : Form
    {
        public CategoryScreenForm()
        {
            InitializeComponent();

            this.ConfigDialog();
        }

        public Category GetCategory()
        {
            int id = Convert.ToInt32(txtId.Text);

            string title = txtTitle.Text;

            return new Category(id, title);
        }

        public void ConfigScreen(Category category)
        {
            txtId.Text = category.id.ToString();
            txtTitle.Text = category.title;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Category category = GetCategory();

            string[] errors = category.Errors();

            if (errors.Length > 0)
            {
                MainScreenForm.Instance.UpdateFooter(errors[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
