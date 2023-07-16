namespace eAgenda.Infra.Data.FileSerialization.Shared
{
    public abstract class RepositoryFileSerializationBase<EntityType>
                          where EntityType : EntityBase<EntityType>
    {
        protected static int counter;

        protected DataContext dataContext;

        public RepositoryFileSerializationBase(DataContext dataContext)
        {
            this.dataContext = dataContext;
            
            UpdateCounter();
        }

        protected abstract List<EntityType> GetRecord();

        public void Add(EntityType newEntity)
        {
            counter++;
            newEntity.id = counter;

            List<EntityType> recordsList = GetRecord();

            recordsList.Add(newEntity);

            dataContext.RecordJson();
        }

        public void Update(int id, EntityType updateEntity)
        {
            EntityType selectedEntity = SelectId(id);

            selectedEntity.UpdateInfos(updateEntity);

            dataContext.RecordJson();
        }

        public void Delete(EntityType selectedEntity)
        {
            List<EntityType> recordsList = GetRecord();

            recordsList.Remove(selectedEntity);

            dataContext.RecordJson();
        }

        public List<EntityType> GetAll()
        {
            return GetRecord();
        }

        public EntityType SelectId(int id)
        {
            List<EntityType> recordsList = GetRecord();
            return recordsList.FirstOrDefault(x => x.id == id);
        }

        private void UpdateCounter()
        {
            if (GetRecord().Count > 0)
                counter = GetRecord().Max(x => x.id);
        }
    }
}
