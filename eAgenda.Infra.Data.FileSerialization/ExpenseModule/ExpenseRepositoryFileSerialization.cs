using eAgenda.Domain.CategoryModule;
using eAgenda.Domain.ExpenseModule;

namespace eAgenda.Infra.Data.FileSerialization.ExpenseModule
{
    public class ExpenseRepositoryFileSerialization : RepositoryFileSerializationBase<Expense>, IExpenseRepository
    {
        public ExpenseRepositoryFileSerialization()
        {
            EntityName = "Expense";
        }

        public List<Expense> GetByCategories(Category category)
        {
            return (from n in recordsList where n.categories.Contains(category) select n).ToList();
        }
    }
}
