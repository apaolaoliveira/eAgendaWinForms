using eAgenda.Domain.ExpenseModule;

namespace eAgenda.Infra.Data.Memory.ExpenseModule
{
    public class ExpenseRepositoryMemory : RepositoryMemoryBase<Expense>, IExpenseRepository
    {
        public ExpenseRepositoryMemory(List<Expense> expenses) : base(expenses) { }
    }
}
