using eAgenda.Domain.CategoryModule;

namespace eAgenda.Domain.ExpenseModule
{
    public interface IExpenseRepository
    {
        void Add(Expense newExpense);
        void Update(int id, Expense updateExpense);
        void Delete(Expense expense);
        Expense SelectId(int id);
        List<Expense> GetAll();
        List<Expense> GetByCategories(Category category);
    }
}
