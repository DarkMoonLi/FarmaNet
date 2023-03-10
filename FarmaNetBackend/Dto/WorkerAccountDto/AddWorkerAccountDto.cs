using FarmaNetBackend.Domain.Models;

namespace FarmaNetBackend.Dto.WorkerAccountDto
{
    public class AddWorkerAccountDto
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int WorkerInformationId { get; set; }
        public int PharmacyId { get; set; }

        public WorkerAccount ConvertToWorkerAccount()
        {
            return new WorkerAccount
            {
                Login = this.Login,
                Password = this.Password,
                WorkerInformationId = this.WorkerInformationId,
                PharmacyId = this.PharmacyId
            };
        }
    }
}
