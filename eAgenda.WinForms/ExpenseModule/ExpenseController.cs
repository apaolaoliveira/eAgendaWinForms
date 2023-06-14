using eAgenda.Domain.ExpenseModule;
using eAgenda.Domain.TaskModule;
using eAgenda.WinForms.TaskModule;

namespace eAgenda.WinForms.ExpenseModule
{
    public class ExpenseController : ControllerBase
    {
        private IExpenseRepository _expenseRepository;
        private GridExpenseControl _expenseGrid;

        public ExpenseController(IExpenseRepository repository)
        {
            _expenseRepository = repository;
        }
        public override string ToolTipAdd => "Add new Expense";

        public override string ToolTipUpdate => "Edit Expense";

        public override string ToolTipDelete => "Delete Expense";

        public override void Add()
        {
            ExpenseScreenForm expenseScreen = new ExpenseScreenForm();
            DialogResult selectedOption = expenseScreen.ShowDialog();

            if (selectedOption == DialogResult.OK)
            {
                Expense newExpense = expenseScreen.GetExpense();
                _expenseRepository.Add(newExpense);

                MessageBox.Show("Informations suscessfuly recorded!");
            }

            UploadExpense();
        }

        public override void Update()
        {
            Expense selectedExpense = GetSelectedExpense();

            if (selectedExpense == null)
            {
                MessageBox.Show("First select a expense!", "Delete Expense", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ExpenseScreenForm screenExpense = new ExpenseScreenForm();

            DialogResult selectedOption = screenExpense.ShowDialog();

            if (selectedOption == DialogResult.OK)
            {
                Expense expense = screenExpense.GetExpense();

                _expenseRepository.Update(expense.id, expense);
            }

            UploadExpense();
        }

        public override void Delete()
        {
            Expense selectedExpense = GetSelectedExpense();

            if (selectedExpense == null)
            {
                MessageBox.Show("First select a Expense!", "Delete Expense", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult selectedOption =
                MessageBox.Show($"Are you sure about deleting \"{selectedExpense.description}\" from your list?",
                                "Delete Expense", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (selectedOption == DialogResult.Yes)
            {
                _expenseRepository.Delete(selectedExpense);

            }

            UploadExpense();
        }

        public override UserControl GetList()
        {
            _expenseGrid = new GridExpenseControl();

            List<Expense> expenses = _expenseRepository.GetAll();

            _expenseGrid.UpdateList(expenses);

            UploadExpense();

            return _expenseGrid;
        }


        private void UploadExpense()
        {
            List<Expense> Expense = _expenseRepository.GetAll();

            _expenseGrid.UpdateList(Expense);

            MainScreenForm.Instance.UpdateFooter($"Viewing {Expense.Count} Categories.");
        }

        private Expense GetSelectedExpense()
        {
            int id = _expenseGrid.GetSelectedId();

            return _expenseRepository.SelectId(id);
        }

        public override string GetRegisterType()
        {
            return "Expenses' Records";
        }
    }
}
