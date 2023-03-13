using FarmaNetBackend.Dto.WorkerAccountDto;
using FarmaNetBackend.Infrastructure;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Repositories
{
    public class WorkerAccountRepository : IWorkerAccountRepository
    {
        ApplicationDbContext _context;

        public WorkerAccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<WorkerAccount> GetWorkerAccounts()
        {
            return _context.WorkerAccounts.ToList();
        }

        public WorkerAccount GetWorkerAccountById(GetWorkerAccountDto workerAccountDto)
        {
            return _context.WorkerAccounts.FirstOrDefault(w => w.WorkerAccountId == workerAccountDto.WorkerAccountId);
        }

        public void AddWorkerAccount(AddWorkerAccountDto workerAccountDto)
        {
            WorkerAccount workerAccount = workerAccountDto.ConvertToWorkerAccount();

            _context.WorkerAccounts.Add(workerAccount);
            _context.SaveChanges();
        }

        public void UpdateWorkerAccount(UpdateWorkerAccountDto workerAccountDto)
        {
            WorkerAccount workerAccount = GetWorkerAccountById(new GetWorkerAccountDto{ WorkerAccountId = workerAccountDto.WorkerAccountId});

            if (workerAccount != null)
            {
                workerAccount.WorkerInformationId = workerAccountDto.WorkerInformationId;
                workerAccount.PharmacyId = workerAccountDto.PharmacyId;
                workerAccount.Login = workerAccountDto.Login;
                workerAccount.Password = workerAccountDto.Password;

                _context.WorkerAccounts.Update(workerAccount);
                _context.SaveChanges();
            }
        }

        public void RemoveWorkerAccount(GetWorkerAccountDto workerAccountDto)
        {
            WorkerAccount workerAccount = GetWorkerAccountById(workerAccountDto);
            
            if (workerAccount != null)
            {
                _context.WorkerAccounts.Remove(workerAccount);
                _context.SaveChanges();
            }
        }
    }
}
