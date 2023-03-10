using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.WorkerAccountDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IWorkerAccountRepository
    {
        public List<WorkerAccount> GetWorkerAccounts();
        public WorkerAccount GetWorkerAccountById(int id);
        public void AddWorkerAccount(AddWorkerAccountDto workerAccountDto);
        public void UpdateWorkerAccount(UpdateWorkerAccountDto workerAccountDto);
        public void RemoveWorkerAccount(int id);
    }
}
