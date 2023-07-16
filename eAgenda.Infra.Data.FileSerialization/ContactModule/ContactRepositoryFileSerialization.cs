using eAgenda.Domain.ContactModule;

namespace eAgenda.Infra.Data.FileSerialization.ContactModule
{
    public class ContactRepositoryFileSerialization : RepositoryFileSerializationBase<Contact>, IContactRepository
    {
        public ContactRepositoryFileSerialization(DataContext dataContext) : base(dataContext) 
        {            
        }

        protected override List<Contact> GetRecord()
        {
            return dataContext.contacs;
        }
    }
}
