namespace eAgenda.Domain.ContactModule
{
    public interface IContactRepository
    {
        void Add(Contact newContact);
        void Update(int id, Contact updateContact);
        void Delete(Contact contact);
        Contact SelectId(int id);
        List<Contact> GetAll();
    }
}
