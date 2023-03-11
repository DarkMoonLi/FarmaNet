namespace FarmaNetBackend.Dto.WorkerAccountDto
{
    public class UpdateWorkerAccountDto
    {
        public int WorkerAccountId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int WorkerInformationId { get; set; }
        public int PharmacyId { get; set; }
    }
}
