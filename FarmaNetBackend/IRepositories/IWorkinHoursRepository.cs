using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.WorkingHoursDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IWorkinHoursRepository
    {
        public List<WorkingHours> GetWorkingHours();
        public WorkingHours GetWorkingHoursById(GetWorkingHoursDto workingHoursDto);
        public void AddWorkingHours(AddWorkingHoursDto workingHoursDto);
        public void UpdateWorkingHours(UpdateWorkingHoursDto workingHoursDto);
        public void RemoveWorkingHours(GetWorkingHoursDto workingHoursDto);
    }
}
