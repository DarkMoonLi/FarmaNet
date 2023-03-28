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

        public List<WriteDownsReportDto> GetWriteDownsByPharmacy(int id)
        {
            List<WriteDowns> writeDowns = _context.WriteDowns.Where(w => w.PharmacyId.Equals(id)).ToList();

            List<WriteDownsReportDto> writeDownsReportDto = new List<WriteDownsReportDto>();

            foreach (WriteDowns writeDown in writeDowns)
            {
                Medication med = _context.Medications.FirstOrDefault(m => m.MedicationId.Equals(writeDown.MedicationId));

                if (med != null)
                {
                    WriteDownsReportDto writeDownsDto = new WriteDownsReportDto();

                    writeDownsDto.MedicationName = med.Name;
                    writeDownsDto.Quantity = writeDown.Quantity;

                    writeDownsReportDto.Add(writeDownsDto);
                }
            }

            return writeDownsReportDto;
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
