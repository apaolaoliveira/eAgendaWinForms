using eAgenda.Domain.CategoryModule;

namespace eAgenda.Infra.Data.FileSerialization.CategoryModule
{
    public class CategoryRepositoryFileSerialization : RepositoryFileSerializationBase<Category>, ICategoryRepository
    {
        public CategoryRepositoryFileSerialization()
        {
            EntityName = "Category";
        }
    }
}
