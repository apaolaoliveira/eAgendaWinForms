using eAgenda.Domain.CategoryModule;
using eAgenda.Domain.ExpenseModule;

namespace eAgenda.Infra.Data.Memory.ExpenseModule
{
    public class ExpenseRepositoryMemory : RepositoryMemoryBase<Expense>, IExpenseRepository
    {
        public ExpenseRepositoryMemory(List<Expense> expenses) : base(expenses) { }

        public List<Expense> GetByCategories(Category category)
        {
            return (from n in recordsList where n.categories.Contains(category) select n).ToList(); 
        }
    }
}
