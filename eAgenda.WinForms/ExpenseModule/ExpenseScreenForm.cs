using eAgenda.Domain.CategoryModule;
using eAgenda.Domain.ExpenseModule;
using System.Xml.Linq;

namespace eAgenda.WinForms.ExpenseModule
{
    public partial class ExpenseScreenForm : Form
    {
        public ExpenseScreenForm(List<Category> categories)
        {
            InitializeComponent();

            this.ConfigDialog();

            ConfigPaymentMethod();

            ConfigCategory(categories);
        }

        private void ConfigPaymentMethod()
        {
            ExpensePaymentMethodEnum[] paymentEnum = Enum.GetValues<ExpensePaymentMethodEnum>();

            foreach (ExpensePaymentMethodEnum pay in paymentEnum)
            {
                cmbPay.Items.Add(pay);
            }
        }

        public void ConfigCategory(List<Category> categories)
        {
            listItemsCategories.Items.Clear();

            categories.ForEach(c => listItemsCategories.Items.Add(c));
        }

        public void ConfigScreen(Expense selectedExpense)
        {
            txtId.Text = selectedExpense.id.ToString();
            txtDescription.Text = selectedExpense.description;
            txtDate.Text = selectedExpense.date.ToString();
            txtPrice.Text = selectedExpense.price.ToString();
            cmbPay.Text = selectedExpense.paymentMethod.ToString();

            for (int i = 0; i < listItemsCategories.Items.Count; i++)
            {
                Category category = (Category)listItemsCategories.Items[i];

                if (selectedExpense.categories.Contains(category))
                {
                    listItemsCategories.SetItemChecked(i, true);
                }
            }
        }

        public Expense GetExpense()
        {
            string description = txtDescription.Text;

            DateTime date = txtDate.Value;

            string onlyNumbers = txtPrice.Text.Replace("R$", "");

            decimal price = Convert.ToDecimal(onlyNumbers);

            ExpensePaymentMethodEnum pay = (ExpensePaymentMethodEnum)cmbPay.SelectedItem;

            List<Category> categories = listItemsCategories.CheckedItems.Cast<Category>().ToList();

            Expense expense = new Expense(description, date, price, pay, categories);

            return expense;
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
