using eAgenda.Domain.ExpenseModule;

namespace eAgenda.WinForms.ExpenseModule
{
    public partial class ExpenseScreenForm : Form
    {
        public ExpenseScreenForm()//List<Category> categories)
        {
            InitializeComponent();

            this.ConfigDialog();

            ConfigPaymentMethod();
            //ConfigCategory(categories);
        }

        private void ConfigPaymentMethod()
        {
            ExpensePaymentMethodEnum[] pay = Enum.GetValues<ExpensePaymentMethodEnum>();

            foreach (ExpensePaymentMethodEnum p in pay)
            {
                cmbPay.Items.Add(p);
            }
        }

        public void ConfigCategory(List<Category> categories)
        {
            foreach (Category category in categories)
            {
                cbCategory.Items.Add(category);
            }
        }

        public Expense GetExpense()
        {
            string description = txtDescription.Text;

            DateTime date = txtDate.Value;

            decimal price = Convert.ToDecimal(txtPrice.Text);

            ExpensePaymentMethodEnum pay = (ExpensePaymentMethodEnum)cmbPay.SelectedItem;

            Category category = (Category)cbCategory.SelectedItem;

            return new Expense(description, date, price, pay, category);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Expense expense = GetExpense();

            string[] errors = expense.Errors();

            if (errors.Length > 0)
            {
                MainScreenForm.Instance.UpdateFooter(errors[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
