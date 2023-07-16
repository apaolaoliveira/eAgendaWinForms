using eAgenda.Domain.CategoryModule;
using eAgenda.Domain.CommitmentModule;
using eAgenda.Domain.ContactModule;
using eAgenda.Domain.ExpenseModule;
using System.Diagnostics.Metrics;
using System.Text.Json;

namespace eAgenda.Infra.Data.FileSerialization.Shared
{
    public class DataContext
    {
        public List<Contact> contacs;
        public List<Commitment> commitments;
        public List<Domain.TaskModule.Task> tasks;
        public List<Expense> expenses;
        public List<Category> categories;

        //public void RecordJson()
        //{
        //    JsonSerializerOptions jsonOptions = new JsonSerializerOptions();
        //    jsonOptions.IncludeFields = true;
        //    jsonOptions.WriteIndented = true;

        //    string recordListJson = JsonSerializer.Serialize(recordsList, jsonOptions);

        //    if (!Directory.Exists(_filePath))
        //        Directory.CreateDirectory(_DirectoryPath);

        //    File.WriteAllText(_filePath, recordListJson);
        //}

        //public void UploadJson()
        //{
        //    if (!File.Exists(_filePath))
        //        return;

        //    JsonSerializerOptions jsonOptions = new JsonSerializerOptions();
        //    jsonOptions.IncludeFields = true;

        //    string recordListJson = File.ReadAllText(_filePath);

        //    recordsList = JsonSerializer.Deserialize<List<EntityType>>(recordListJson, jsonOptions);

        //    counter = recordsList.Max(x => x.id);
        //}
    }
}
