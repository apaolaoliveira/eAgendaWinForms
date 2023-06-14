using eAgenda.Domain.ContactModule;

namespace eAgenda.Infra.Data.Memory.ContactMoldule
{
    public class ContactRepositoryMemory : RepositoryMemoryBase<Contact>, IContactRepository
    {
        public ContactRepositoryMemory(List<Contact> contacts) : base(contacts) { }
    }
}
