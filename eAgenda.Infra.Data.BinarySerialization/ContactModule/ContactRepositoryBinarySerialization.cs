using eAgenda.Domain.ContactModule;

namespace eAgenda.Infra.Data.BinarySerialization.ContactModule
{
    public class ContactRepositoryBinarySerialization : RepositoryBinarySerializationBase<Contact>, IContactRepository
    {
        public ContactRepositoryBinarySerialization(List<Contact> recordsList) : base(recordsList)
        {
            EntityName = "contact";

            UploadEntityFromFile();
        }
    }
}
