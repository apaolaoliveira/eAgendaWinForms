using eAgenda.Domain.CategoryModule;

namespace eAgenda.Infra.Data.Memory.CategoryModule
{
    public class CategoryRepositoryMemory : RepositoryMemoryBase<Category>, ICategoryRepository
    {
        public CategoryRepositoryMemory(List<Category> recordsList) : base(recordsList) { }
    }
}
