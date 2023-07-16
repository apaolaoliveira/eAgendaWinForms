using eAgenda.Domain.ContactModule;

namespace eAgenda.Infra.Data.FileSerialization.ContactModule
{
    public class ContactRepositoryFileSerialization : RepositoryFileSerializationBase<Contact>, IContactRepository
    {
        public ContactRepositoryFileSerialization()
        {
            EntityName = "Contact";
        }
    }
}
