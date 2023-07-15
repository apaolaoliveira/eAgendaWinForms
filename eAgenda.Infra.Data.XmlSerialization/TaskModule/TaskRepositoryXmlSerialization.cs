using eAgenda.Domain.TaskModule;

namespace eAgenda.Infra.Data.XmlSerializations.TaskModule
{
    public class TaskRepositoryXmlSerialization : RepositoryXmlSerializationBase<Domain.TaskModule.Task>, ITaskRepository
    {
        public TaskRepositoryXmlSerialization(List<Domain.TaskModule.Task> recordsList) : base(recordsList)
        {
            EntityName = "task";

            UploadEntityFromFile();
        }

        public List<Domain.TaskModule.Task> SelectByPriorities()
        {
            return GetAll()
                    .OrderBy(x => x.priority)
                        .ToList();
        }

        public List<Domain.TaskModule.Task> SelectPending()
        {
            return GetAll()
                    .Where(x => x.percentCompleted < 100)
                        .ToList();
        }

        public List<Domain.TaskModule.Task> SelectDone()
        {
            return GetAll()
                    .Where(x => x.percentCompleted == 100)
                         .ToList();
        }
    }
}
