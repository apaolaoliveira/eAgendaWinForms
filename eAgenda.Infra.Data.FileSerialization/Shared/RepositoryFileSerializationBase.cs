using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

// The bin serialization is the language that only the computer can understand.

/* 
 * The difference of the xml serialization to binary serialization is the class XmlSerializer and the 
 * parameterless constructor on each class of domain, but the main difference is that we can understant
 * what is on the file after record it.
*/

namespace eAgenda.Infra.Data.FileSerialization.Shared
{
    public  class RepositoryFileSerializationBase<EntityType>
                          where EntityType : EntityBase<EntityType>
    {
        protected List<EntityType> recordsList = new List<EntityType>();

        protected static int counter;

        protected static string EntityName { get; set; }

        protected static string SerializationType { get; set; }

        private string _DirectoryPath => @$"aAgendaRecords/{EntityName}Module";

        private string _fileName => $"{EntityName}Records.json";

        private string _filePath => Path.Combine(_DirectoryPath, _fileName);

        protected RepositoryFileSerializationBase()
        {
            UploadJson();
        }

        public void Add(EntityType newEntity)
        {
            counter++;
            newEntity.id = counter;

            recordsList.Add(newEntity);

            RecordJson();
        }

        public void Update(int id, EntityType updateEntity)
        {
            EntityType selectedEntity = SelectId(id);

            selectedEntity.UpdateInfos(updateEntity);

            RecordJson();
        }

        public void Delete(EntityType selectedEntity)
        {
            recordsList.Remove(selectedEntity);

            RecordJson();
        }

        public List<EntityType> GetAll()
        {
            return recordsList;
        }

        public EntityType SelectId(int id)
        {
            return recordsList.FirstOrDefault(x => x.id == id);
        }

        // Records -------------------------------------------------------------------------------------------------------

        private void RecordBin()
        {
            BinaryFormatter serializer = new BinaryFormatter();

            MemoryStream EntityStream = new MemoryStream(); // A stream is a way to represents a file on the memory

            serializer.Serialize(EntityStream, recordsList); // It's like a .ToString() for objects

            byte[] EntityInBytes = EntityStream.ToArray();

            if (!Directory.Exists(_filePath))
                Directory.CreateDirectory(_DirectoryPath);

            File.WriteAllBytes(_filePath, EntityInBytes);
        }

        private void RecordXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<EntityType>));

            MemoryStream EntityStream = new MemoryStream();

            serializer.Serialize(EntityStream, recordsList);

            byte[] EntityInBytes = EntityStream.ToArray();

            if (!Directory.Exists(_filePath))
                Directory.CreateDirectory(_DirectoryPath);

            File.WriteAllBytes(_filePath, EntityInBytes);
        }


        private void RecordJson()
        {
            JsonSerializerOptions jsonOptions = new JsonSerializerOptions();
            jsonOptions.IncludeFields = true;
            jsonOptions.WriteIndented = true;
            
            string recordListJson = JsonSerializer.Serialize(recordsList, jsonOptions);
            
            if (!Directory.Exists(_filePath))
                Directory.CreateDirectory(_DirectoryPath);

            File.WriteAllText(_filePath, recordListJson);
        }

        // Uploads -------------------------------------------------------------------------------------------------------


        public void UploadBin()
        {
            if (!File.Exists(_filePath))
                return;

            BinaryFormatter serializer = new BinaryFormatter();

            byte[] entityBytes = File.ReadAllBytes(_filePath);

            MemoryStream stream = new MemoryStream(entityBytes);

            recordsList = (List<EntityType>)serializer.Deserialize(stream);

            counter = recordsList.Max(x => x.id);
        }

        public void UploadXml()
        {
            if (!File.Exists(_filePath))
                return;

            XmlSerializer serializer = new XmlSerializer(typeof(List<EntityType>));

            byte[] entityBytes = File.ReadAllBytes(_filePath);

            MemoryStream stream = new MemoryStream(entityBytes);

            recordsList = (List<EntityType>)serializer.Deserialize(stream);

            counter = recordsList.Max(x => x.id);
        }

        public void UploadJson()
        {
            if (!File.Exists(_filePath))
                return;

            JsonSerializerOptions jsonOptions = new JsonSerializerOptions();
            jsonOptions.IncludeFields = true;

            string recordListJson = File.ReadAllText(_filePath);

            recordsList = JsonSerializer.Deserialize<List<EntityType>>(recordListJson, jsonOptions);

             counter = recordsList.Max(x => x.id);
        }    
    }
}
