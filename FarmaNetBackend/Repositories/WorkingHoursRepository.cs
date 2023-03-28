using FarmaNetBackend.Dto.WorkingHoursDto;
using FarmaNetBackend.Infrastructure;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Repositories
{
    public class WorkingHoursRepository : IWorkinHoursRepository
    {
        ApplicationDbContext _context;

        public WorkingHoursRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<WorkingHours> GetWorkingHours()
        {
            return _context.WorkingHours.ToList();
        }

        public List<WorkingHours> GetWorkingHoursByWorker(int id)
        {
            List<WorkingHours> workingHours = _context.WorkingHours.Where(w => w.WorkerAccountId.Equals(id)).ToList();

            return workingHours;
        }

        public WorkingHours GetWorkingHoursById(GetWorkingHoursDto workingHoursDto)
        {
            return _context.WorkingHours.FirstOrDefault(w => w.WorkingHoursId == workingHoursDto.WorkingHoursId);
        }

        public void AddWorkingHours(AddWorkingHoursDto workingHoursDto)
        {
            WorkingHours workingHours = workingHoursDto.ConvertToWorkingHours();

            _context.WorkingHours.Add(workingHours);
            _context.SaveChanges();
        }

        public void UpdateWorkingHours(UpdateWorkingHoursDto workingHoursDto)
        {
            WorkingHours workingHours = GetWorkingHoursById(new GetWorkingHoursDto{WorkingHoursId = workingHoursDto.WorkingHoursId});

            if (workingHours != null)
            {
                workingHours.Description = workingHoursDto.Description;
                workingHours.Date = workingHoursDto.Date;
                workingHours.WorkerAccountId = workingHoursDto.WorkerAccountId;
                workingHours.Time = workingHoursDto.Time;

                _context.WorkingHours.Update(workingHours);
                _context.SaveChanges();
            }
        }

        public void RemoveWorkingHours(GetWorkingHoursDto workingHoursDto)
        {
            WorkingHours workingHours = GetWorkingHoursById(workingHoursDto);

            if (workingHours != null)
            {
                _context.WorkingHours.Remove(workingHours);
                _context.SaveChanges();
            }
        }
    }
}
