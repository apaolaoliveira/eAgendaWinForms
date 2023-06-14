namespace eAgenda.Domain.Shared
{
    [Serializable]
    public abstract class EntityBase<EntityType>
    {
        public int id;
        public abstract void UpdateInfos(EntityType updateRecord);
        public abstract string[] Errors();
    }
}
