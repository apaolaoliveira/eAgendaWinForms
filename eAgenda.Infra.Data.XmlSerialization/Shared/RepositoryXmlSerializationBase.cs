using System.Xml.Serialization;

/* 
 * The difference of the xml serialization to binary serialization is the class XmlSerializer and the 
 * parameterless constructor on each class of domain, but the main difference is that we can understant
 * what is on the file after record it.
*/

namespace eAgenda.Infra.Data.XmlSerialization.Shared
{
    public class RepositoryXmlSerializationBase<EntityType>
                          where EntityType : EntityBase<EntityType>
    {
        protected static int _counter;

        protected List<EntityType> recordsList;

        protected static string EntityName { get; set; }

        protected static string _FILE_NAME => $"aAgendaRecordsXml/{EntityName}Records.xml";

        protected RepositoryXmlSerializationBase(List<EntityType> recordsList)
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
            XmlSerializer serializer = new XmlSerializer(typeof(List<EntityType>));

            MemoryStream EntityStream = new MemoryStream();

            serializer.Serialize(EntityStream, recordsList);

            byte[] EntityInBytes = EntityStream.ToArray();

            if (!File.Exists(_FILE_NAME))
                Directory.CreateDirectory("aAgendaRecordsXml");

            File.WriteAllBytes(_FILE_NAME, EntityInBytes);
        }

        public void UploadEntityFromFile()
        {
            if (!File.Exists(_FILE_NAME))
                return;

            XmlSerializer serializer = new XmlSerializer(typeof(List<EntityType>));

            byte[] entityBytes = File.ReadAllBytes(_FILE_NAME);

            MemoryStream stream = new MemoryStream(entityBytes);

            recordsList = (List<EntityType>)serializer.Deserialize(stream);

            _counter = recordsList.Max(x => x.id);
        }
    }
}
