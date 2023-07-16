using eAgenda.Domain.CategoryModule;

namespace eAgenda.Infra.Data.FileSerialization.CategoryModule
{
    public class CategoryRepositoryFileSerialization : RepositoryFileSerializationBase<Category>, ICategoryRepository
    {
        public CategoryRepositoryFileSerialization(DataContext dataContext) : base(dataContext)
        {           
        }

        protected override List<Category> GetRecord()
        {
            return dataContext.categories;
        }
    }
}
