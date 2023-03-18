using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.WorkerAccountDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IWorkerAccountRepository
    {
        public List<WorkerAccount> GetWorkerAccounts();
        public WorkerAccount GetWorkerAccountById(GetWorkerAccountDto workerAccountDto);
        public void AddWorkerAccount(AddWorkerAccountDto workerAccountDto);
        public void UpdateWorkerAccount(UpdateWorkerAccountDto workerAccountDto);
        public void RemoveWorkerAccount(GetWorkerAccountDto workerAccountDto);
    }
}
