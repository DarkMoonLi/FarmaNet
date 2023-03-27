using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace FarmaNetBackend.IRepositories
{
    public interface IAuthorizationRepository
    {
        public WorkerAccount Login(WorkerAccount account);
    }
}
