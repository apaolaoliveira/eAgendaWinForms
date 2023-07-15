using eAgenda.Domain.ContactModule;

namespace eAgenda.Infra.Data.XmlSerialization.ContactModule
{
    public class ContactRepositoryXmlSerialization : RepositoryXmlSerializationBase<Contact>, IContactRepository
    {
        public ContactRepositoryXmlSerialization(List<Contact> recordsList) : base(recordsList)
        {
            EntityName = "contact";

            UploadEntityFromFile();
        }
    }
}
