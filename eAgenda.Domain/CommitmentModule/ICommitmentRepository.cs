namespace eAgenda.Domain.CommitmentModule
{
    public interface ICommitmentRepository
    {
        void Add(Commitment newCommitment);
        void Update(int id, Commitment updateCommitment);
        void Delete(Commitment commitment);
        Commitment SelectId(int id);
        List<Commitment> SelectFutureCommitment(DateTime startDate, DateTime endDate);
        List<Commitment> SelectPastCommitment(DateTime now);
        List<Commitment> GetAll();
    }
}
