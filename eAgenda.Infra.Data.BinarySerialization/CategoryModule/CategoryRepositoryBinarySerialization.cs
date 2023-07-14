using eAgenda.Domain.CategoryModule;

namespace eAgenda.Infra.Data.BinarySerialization.CategoryModule
{
    public class CategoryRepositoryBinarySerialization : RepositoryBinarySerializationBase<Category>, ICategoryRepository
    {
        public CategoryRepositoryBinarySerialization(List<Category> recordsList) : base(recordsList) 
        {
            EntityName = "category";

            UploadEntityFromFile();
        }
    }
}
