using eAgenda.Domain.CategoryModule;

namespace eAgenda.Infra.Data.XmlSerialization.CategoryModule
{
    public class CategoryRepositoryXmlSerialization : RepositoryXmlSerializationBase<Category>, ICategoryRepository
    {
        public CategoryRepositoryXmlSerialization(List<Category> recordsList) : base(recordsList) 
        {
            EntityName = "category";

            UploadEntityFromFile();
        }
    }
}
