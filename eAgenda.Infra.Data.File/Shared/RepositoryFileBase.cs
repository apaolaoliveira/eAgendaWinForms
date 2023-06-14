using System.Runtime.Serialization.Formatters.Binary;

namespace eAgenda.Infra.Data.File.Shared
{
    public class RepositoryFileBase<EntityType>
                 where EntityType : EntityBase<EntityType>
    {
        private static int _counter;

        protected List<EntityType> recordsList = new List<EntityType>();

        protected string FILE_NAME = "";

        public virtual void Add(EntityType newRecord)
        {
            _counter++;
            newRecord.id = _counter;
            recordsList.Add(newRecord);

            WriteRecordsFile();
        }

        public virtual void Update(int id, EntityType updateRecord)
        {
            EntityBase<EntityType> selectedRecord = selectedId(id);
            selectedRecord.UpdateInfos(updateRecord);

            WriteRecordsFile();
        }

        public virtual void Delete(EntityType selectedRecord)
        {
            recordsList.Remove(selectedRecord);

            WriteRecordsFile();
        }

        public virtual EntityType selectedId(int id)
        {
            if (recordsList.Exists(record => record.id == id))
                return recordsList.FirstOrDefault(record => record.id == id);

            return null;
        }

        public virtual List<EntityType> GetAll()
        {
            return recordsList.OrderByDescending(x => x.id).ToList();
        }

        public void UpdateCounter()
        {
            _counter = recordsList.Max(x => x.id);
        }

        protected void UploadRecordFile()
        {
            BinaryFormatter serializer = new BinaryFormatter();

            byte[] bytesRecords = File.ReadAllBytes(FILE_NAME);

            MemoryStream recordStream = new MemoryStream(bytesRecords);

            recordsList = (List<EntityType>)serializer.Deserialize(recordStream);

            UpdateCounter();
        }

        public void WriteRecordsFile()
        {
            BinaryFormatter serializer = new BinaryFormatter();

            MemoryStream recordStream = new MemoryStream();

            serializer.Serialize(recordStream, recordsList);

            byte[] byteRecords = recordStream.ToArray();

            File.WriteAllBytes(FILE_NAME, byteRecords);
        }
    }
