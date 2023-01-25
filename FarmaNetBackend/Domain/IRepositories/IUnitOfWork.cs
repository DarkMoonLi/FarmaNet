namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}