using FarmaNetBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaNetBackend.Dto.WorkerAccountDto
{
    public class WorkerAccountDto
    {
        public int WorkerAccountId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int WorkerInformationId { get; set; }
        public int PharmacyId { get; set; }

        public WorkerAccountDto(WorkerAccount workerAccount)
        {
            WorkerAccountId = workerAccount.WorkerAccountId;
            Login = workerAccount.Login;
            Password = workerAccount.Password;
            WorkerInformationId = workerAccount.WorkerInformationId;
            PharmacyId = workerAccount.PharmacyId;
        }
    }
}
