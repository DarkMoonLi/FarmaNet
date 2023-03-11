using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.WorkerInformationDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IWorkerInformationRepository
    {
        public List<WorkerInformation> GetWorkerInformations();
        public WorkerInformation GetWorkerInformationById(int id);
        public void AddWorkerInformation(AddWorkerInformationDto workerInformationDto);
        public void UpdateWorkerInformation(UpdateWorkerInformationDto workerInformationDto);
        public void RemoveWorkerInformation(int id);
    }
}
