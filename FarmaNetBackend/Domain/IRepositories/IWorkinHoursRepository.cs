using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.WorkingHours;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IWorkinHoursRepository
    {
        public List<WorkingHours> GetWorkingHours();
        public WorkingHours GetWorkingHoursById(int id);
        public void AddWorkingHours(WorkingHoursDto workingHoursDto);
        public void UpdateWorkingHours(WorkingHoursDto workingHoursDto);
        public void RemoveWorkinHours(int id);
    }
}
