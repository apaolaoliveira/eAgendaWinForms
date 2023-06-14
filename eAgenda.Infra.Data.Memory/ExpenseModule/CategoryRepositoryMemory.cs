using eAgenda.Domain.ExpenseModule;

namespace eAgenda.Infra.Data.Memory.ExpenseModule
{
    public class CategoryRepositoryMemory : RepositoryMemoryBase<Category>, ICategoryRepository
    {
        public CategoryRepositoryMemory(List<Category> recordsList) : base(recordsList) { }
    }
}
