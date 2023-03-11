using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.WriteDownsDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IWriteDownsRepository
    {
        public List<WriteDowns> GetWriteDowns();
        public WriteDowns GetWriteDownById(int id);
        public void AddWriteDown(AddWriteDownsDto writeDownsDto);
        public void UpdateWriteDown(UpdateWriteDownsDto writeDownsDto);
        public void RemoveWriteDown(int id);
    }
}
