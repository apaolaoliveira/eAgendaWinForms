using eAgenda.Domain.CategoryModule;
using eAgenda.Domain.CommitmentModule;
using eAgenda.Domain.ContactModule;
using eAgenda.Domain.ExpenseModule;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace eAgenda.Infra.Data.FileSerialization.Shared
{
    public class DataContext // Container
    {
        private const string _DIRECTORY = "Shared";
        private const string _FILE = "eAgenda.json";

        private string _filePath = Path.Combine(_DIRECTORY, _FILE);

        public List<Contact> contacs;
        public List<Commitment> commitments;
        public List<Domain.TaskModule.Task> tasks;
        public List<Expense> expenses;
        public List<Category> categories;

        public DataContext()
        {
            this.contacs = new List<Contact>();
            this.commitments = new List<Commitment>();
            this.tasks = new List<Domain.TaskModule.Task>();
            this.expenses = new List<Expense> ();
            this.categories = new List<Category>();
        }

        public DataContext(bool upload) : this()
        {
            UploadJson();
        }

        public void RecordJson()
        {
            JsonSerializerOptions jsonOptions = GetJsonConfigs();            

            string recordListJson = JsonSerializer.Serialize(this, jsonOptions);

            if (!Directory.Exists(_filePath))
                Directory.CreateDirectory(_DIRECTORY);

            File.WriteAllText(_filePath, recordListJson);
        }

        private void UploadJson()
        {
            if (!File.Exists(_filePath))
                return;

            JsonSerializerOptions jsonOptions = GetJsonConfigs();

            string recordListJson = File.ReadAllText(_filePath);

            DataContext ctx = JsonSerializer.Deserialize<DataContext>(recordListJson, jsonOptions);

            this.contacs = ctx.contacs;
            this.commitments = ctx.commitments;
            this.tasks = ctx.tasks;
            this.expenses = ctx.expenses;
            this.categories = ctx.categories;
        }

        private JsonSerializerOptions GetJsonConfigs()
        {
            JsonSerializerOptions jsonOptions = new JsonSerializerOptions();
            jsonOptions.IncludeFields = true;
            jsonOptions.WriteIndented = true; 
            jsonOptions.ReferenceHandler = ReferenceHandler.Preserve;
            return jsonOptions;
        }
    }
}
