using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.MedicationWithManufacturerDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IMedicationWithManufacturerRepository
    {
        public List<MedicationWithManufacturer> GetMedicationWithManufacturers();
        public MedicationWithManufacturer GetMedicationWithManufacturerById(GetMedicationWithManufacturerDto medicationWithManufacturerDto);
        public void AddMedicationWithManufacturer(AddMedicationWithManufacturerDto medicationWithManufacturerDto);
        public void UpdateMedicationWithManufacturer(UpdateMedicationWithManufacturerDto medicationWithManufacturerDto);
        public void RemoveMedicationWithManufacturer(GetMedicationWithManufacturerDto medicationWithManufacturerDto);
    }
}
