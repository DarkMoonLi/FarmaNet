namespace FarmaNetBackend.IRepositories
{
    public interface IUnitOfWork
    {
        public void Commit();
    }
}