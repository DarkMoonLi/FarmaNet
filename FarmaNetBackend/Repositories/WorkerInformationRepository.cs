using FarmaNetBackend.Dto.WorkerInformationDto;
using FarmaNetBackend.Infrastructure;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Repositories
{
    public class WorkerInformationRepository : IWorkerInformationRepository
    {
        public ApplicationDbContext _context;

        public WorkerInformationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<WorkerInformation> GetWorkerInformations()
        {
            return _context.WorkersInformation.ToList();
        }

        public WorkerInformation GetWorkerInformationById(GetWorkerInformationDto workerInformationDto)
        {
            return _context.WorkersInformation.FirstOrDefault(w => w.WorkerInformationId == workerInformationDto.WorkerInformationId);
        }

        public void AddWorkerInformation(AddWorkerInformationDto workerInformationDto)
        {
            WorkerInformation workerInformation = workerInformationDto.ConvertToWorkerInformation();

            _context.WorkersInformation.Add(workerInformation);
            _context.SaveChanges();
        }

        public void UpdateWorkerInformation(UpdateWorkerInformationDto workerInformationDto)
        {
            WorkerInformation workerInformation = GetWorkerInformationById(new GetWorkerInformationDto{WorkerInformationId = workerInformationDto.WorkerInformationId});

            if (workerInformation != null)
            {
                workerInformation.Experience               = workerInformationDto.Experience;
                workerInformation.Name                     = workerInformationDto.Name;
                workerInformation.Email                    = workerInformationDto.Email;
                workerInformation.BirthDate                = workerInformationDto.DataBirth;
                workerInformation.PassportNumber           = workerInformation.PassportNumber;
                workerInformation.PassportSeries           = workerInformation.PassportSeries;
                workerInformation.LastName                 = workerInformationDto.LastName;
                workerInformation.PositionId               = workerInformationDto.PositionId;
                workerInformation.WorkerInformationImageId = workerInformationDto.WorkerInfromationImageId;
                
                _context.WorkersInformation.Update(workerInformation);
                _context.SaveChanges();
            }
        }

        public void RemoveWorkerInformation(GetWorkerInformationDto workerInformationDto)
        {
            WorkerInformation workerInformation = GetWorkerInformationById(workerInformationDto);

            if (workerInformation != null)
            {
                _context.WorkersInformation.Remove(workerInformation);
                _context.SaveChanges();
            }
        }
    }
}
