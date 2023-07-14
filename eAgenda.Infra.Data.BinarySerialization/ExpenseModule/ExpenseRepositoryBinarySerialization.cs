using eAgenda.Domain.CategoryModule;
using eAgenda.Domain.ExpenseModule;

namespace eAgenda.Infra.Data.BinarySerialization.ExpenseModule
{
    public class ExpenseRepositoryBinarySerialization : RepositoryBinarySerializationBase<Expense>, IExpenseRepository
    {
        public ExpenseRepositoryBinarySerialization(List<Expense> recordsList) : base(recordsList)
        {
            EntityName = "expense";

            UploadEntityFromFile();
        }

        public List<Expense> GetByCategories(Category category)
        {
            return (from n in recordsList where n.categories.Contains(category) select n).ToList();
        }
    }
}
