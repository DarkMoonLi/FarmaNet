using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.WorkerInformationDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IWorkerInformationRepository
    {
        public List<WorkerInformationDto> GetWorkerInformations();
        public WorkerInformationDto GetWorkerInformationById(int id);
        public Pharmacy GetPharmacyByWorkerInformationId(int id);
        public Position GetPositionByWorkerInformationId(int id);
        public void AddWorkerInformation(AddWorkerInformationDto workerInformationDto);
        public void UpdateWorkerInformation(UpdateWorkerInformationDto workerInformationDto);
        public void RemoveWorkerInformation(GetWorkerInformationDto workerInformationDto);
    }
}
