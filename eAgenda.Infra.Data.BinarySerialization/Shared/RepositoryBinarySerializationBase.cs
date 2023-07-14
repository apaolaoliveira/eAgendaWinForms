using System.Runtime.Serialization.Formatters.Binary;

namespace eAgenda.Infra.Data.BinarySerialization.Shared
{
    public class RepositoryBinarySerializationBase<EntityType>
                          where EntityType : EntityBase<EntityType>
    {
        protected static int _counter;

        protected List<EntityType> recordsList;

        protected static string EntityName { get; set; }

        protected const string _DIRECTORY_PATH = @"c:\temp\aAgendaRecords";

        protected static string _FILE_NAME => $"{EntityName}Records.bin";

        private string _filePath => Path.Combine(_DIRECTORY_PATH, _FILE_NAME);

        protected RepositoryBinarySerializationBase(List<EntityType> recordsList)
        {
            this.recordsList = recordsList;
        }

        public void Add(EntityType newEntity)
        {
            _counter++;
            newEntity.id = _counter;

            recordsList.Add(newEntity);

            RecordEntityOnFile();
        }

        public void Update(int id, EntityType updateEntity)
        {
            EntityType selectedEntity = SelectId(id);

            selectedEntity.UpdateInfos(updateEntity);

            RecordEntityOnFile();
        }

        public void Delete(EntityType selectedEntity)
        {
            recordsList.Remove(selectedEntity);

            RecordEntityOnFile();
        }

        public List<EntityType> GetAll()
        {
            return recordsList;
        }

        public EntityType SelectId(int id)
        {
            return recordsList.FirstOrDefault(x => x.id == id);
        }

        private void RecordEntityOnFile()
        {
            BinaryFormatter serializer = new BinaryFormatter();

            MemoryStream EntityStream = new MemoryStream(); // A stream is a way to represents a file on the memory

            serializer.Serialize(EntityStream, recordsList); // It's like a .ToString() for objects

            byte[] EntityInBytes = EntityStream.ToArray();

            if (!Directory.Exists(_DIRECTORY_PATH))
                Directory.CreateDirectory(_DIRECTORY_PATH);

            File.WriteAllBytes(_filePath, EntityInBytes);
        }

        public void UploadEntityFromFile()
        {
            if (!File.Exists(_filePath))
                return;

            BinaryFormatter serializer = new BinaryFormatter();

            byte[] entityBytes = File.ReadAllBytes(_filePath);

            MemoryStream stream = new MemoryStream(entityBytes);

            recordsList = (List<EntityType>)serializer.Deserialize(stream);

            _counter = recordsList.Max(x => x.id);
        }
    }
}
