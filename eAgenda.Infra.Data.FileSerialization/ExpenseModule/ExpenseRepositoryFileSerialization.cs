using eAgenda.Domain.CategoryModule;
using eAgenda.Domain.ExpenseModule;

namespace eAgenda.Infra.Data.FileSerialization.ExpenseModule
{
    public class ExpenseRepositoryFileSerialization : RepositoryFileSerializationBase<Expense>, IExpenseRepository
    {
        public ExpenseRepositoryFileSerialization(DataContext dataContext) : base(dataContext)
        {
        }

        public List<Expense> GetByCategories(Category category)
        {
            return (from n in dataContext.expenses where n.categories.Contains(category) select n).ToList();
        }

        protected override List<Expense> GetRecord()
        {
            return dataContext.expenses;
        }
    }
}
