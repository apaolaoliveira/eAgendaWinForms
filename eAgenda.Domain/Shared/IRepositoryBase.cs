namespace eAgenda.Domain.Shared
{
    public interface IRepositoryBase<EntityType> where EntityType : EntityBase<EntityType>
    {
        void Add(EntityType entityType);
        void Update(int id, EntityType entityType);
        void Delete(EntityType entityType);
        EntityType SelectId(int id);
        List<EntityType> GetAll();
    }
}
