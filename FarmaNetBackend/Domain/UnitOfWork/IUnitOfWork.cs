namespace FarmaNetBackend.Domain.UnitOfWork
{
    public interface IUnitOfWork
    {
        public void Commit();
    }
}