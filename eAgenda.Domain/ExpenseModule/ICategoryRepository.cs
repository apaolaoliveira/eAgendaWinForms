namespace eAgenda.Domain.ExpenseModule
{
    public interface ICategoryRepository
    {
        void Add(Category newCategory);
        void Update(int id, Category updateCategory);
        void Delete(Category category);
        Category SelectId(int id);
        List<Category> GetAll();
    }
}
