namespace eAgenda.Infra.Data.Memory.Shared
{
    public abstract class RepositoryMemoryBase<EntityType> 
                          where EntityType : EntityBase<EntityType>
    {
        protected List<EntityType> recordsList;
        protected int recordsCounter = 0;

        protected RepositoryMemoryBase(List<EntityType> recordsList)
        {
            this.recordsList = recordsList;
        }

        public virtual List<EntityType> GetAll() { return recordsList.OrderByDescending(x => x.id).ToList(); }

        public int GetQuantity() { return recordsList.Count; }

        public virtual EntityType SelectId(int id)
        {
            if (recordsList.Exists(record => record.id == id))
                return recordsList.First(record => record.id == id);

            return null;
        }

        public virtual void Add(EntityType record)
        {
            recordsCounter++;
            record.id = recordsCounter;

            recordsList.Add(record);
        }

        public virtual void Update(int id, EntityType updateRecord)
        {
            EntityType selectedRecord = SelectId(id);
            selectedRecord.UpdateInfos(updateRecord);
        }

        public virtual void Update(EntityType selectedRecord, EntityType updateRecord) 
        { 
            selectedRecord.UpdateInfos(updateRecord); 
        }

        public virtual void Delete(int id)
        {
            EntityType selectedRecord = SelectId(id);
            
            if(selectedRecord != null)
                recordsList.Remove(selectedRecord);
        }

        public virtual void Delete(EntityType selectedRecord) 
        { 
            recordsList.Remove(selectedRecord); 
        }
    }
}
