namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IUnitOfWork
    {
        public void Commit();
    }
}