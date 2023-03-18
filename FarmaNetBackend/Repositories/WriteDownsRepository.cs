using FarmaNetBackend.Dto.WriteDownsDto;
using FarmaNetBackend.Infrastructure;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Repositories
{
    public class WriteDownsRepository : IWriteDownsRepository
    {
        ApplicationDbContext _context;

        public WriteDownsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<WriteDowns> GetWriteDowns()
        {
            return _context.WriteDowns.ToList();
        }

        public WriteDowns GetWriteDownById(GetWriteDownsDto writeDownsDto)
        {
            return _context.WriteDowns.FirstOrDefault(w => w.PharmacyId == writeDownsDto.PharmacyId && w.MedicationId == writeDownsDto.MedicationId);
        }

        public void AddWriteDown(AddWriteDownsDto writeDownsDto)
        {
            WriteDowns writeDowns = writeDownsDto.ConvertToWriteDowns();

            _context.WriteDowns.Add(writeDowns);
            _context.SaveChanges();
        }

        public void UpdateWriteDown(UpdateWriteDownsDto writeDownsDto)
        {
            WriteDowns writeDowns = GetWriteDownById(new GetWriteDownsDto{ PharmacyId = writeDownsDto.PharmacyId, MedicationId = writeDownsDto.MedicationId });

            if (writeDowns != null)
            {
                writeDowns.Quantity = writeDownsDto.Quantity;

                _context.WriteDowns.Update(writeDowns);
                _context.SaveChanges();
            }
        }

        public void RemoveWriteDown(GetWriteDownsDto writeDownsDto)
        {
            WriteDowns writeDowns = GetWriteDownById(writeDownsDto);

            if (writeDowns != null)
            {
                _context.WriteDowns.Remove(writeDowns);
                _context.SaveChanges();
            }
        }
    }
}
