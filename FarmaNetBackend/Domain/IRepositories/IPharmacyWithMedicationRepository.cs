﻿using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.PharmacyWithMedicationDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IPharmacyWithMedicationRepository
    {
        public List<PharmacyWithMedication> GetPharmacyWithMedications();
        public PharmacyWithMedication GetPharmacyWithMedicationById(int id);
        public void AddPharmacyWithMedication(AddPharmacyWithMedicationDto pharmacyWithMedicationDto);
        public void UpdatePharmacyWithMedication(UpdatePharmacyWithMedicationDto pharmacyWithMedicationDto);
        public void RemovePharmacyWithMedication(int id);
    }
}