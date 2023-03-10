using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.MedicationWithManufacturerDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IMedicationWithManufacturerRepository
    {
        public List<MedicationWithManufacturer> GetMedicationWithManufacturers();
        public MedicationWithManufacturer GetMedicationWithManufacturerById(int id);
        public void AddMedicationWithManufacturer(AddMedicationWithManufacturerDto medicationWithManufacturerDto);
        public void UpdateMedicationWithManufacturer(UpdateMedicationWithManufacturerDto medicationWithManufacturerDto);
        public void RemoveMedicationWithManufacturer(int id);
    }
}
