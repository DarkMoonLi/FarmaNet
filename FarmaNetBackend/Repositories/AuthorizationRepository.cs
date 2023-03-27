using FarmaNetBackend.Infrastructure;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using System.Linq;

namespace FarmaNetBackend.Repositories
{
    public class AuthorizationRepository : IAuthorizationRepository
    {
        readonly ApplicationDbContext _context;

        public AuthorizationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public WorkerAccount Login(WorkerAccount account)
        {
            return _context.WorkerAccounts.FirstOrDefault(p => p.Login == account.Login && p.Password == account.Password);
        }
    }
}
