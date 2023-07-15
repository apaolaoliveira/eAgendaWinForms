using eAgenda.Domain.CategoryModule;
using eAgenda.Domain.ExpenseModule;

namespace eAgenda.Infra.Data.XmlSerializations.ExpenseModule
{
    public class ExpenseRepositoryXmlSerialization : RepositoryXmlSerializationBase<Expense>, IExpenseRepository
    {
        public ExpenseRepositoryXmlSerialization(List<Expense> recordsList) : base(recordsList)
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
