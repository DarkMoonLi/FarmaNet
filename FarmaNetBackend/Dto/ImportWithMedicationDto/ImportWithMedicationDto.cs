﻿using FarmaNetBackend.Models;

namespace FarmaNetBackend.Dto.ImportWithMedicationDto
{
    public class ImportWithMedicationDto
    {
        public int ImportId { get; set; }
        public int MedicationId { get; set; }
        public int Quantity { get; set; }
        public double? Price { get; set; }

        public ImportWithMedicationDto(ImportWithMedication importWithMedication)
        {
            ImportId     = importWithMedication.ImportId;
            MedicationId = importWithMedication.MedicationId;
            Quantity     = importWithMedication.Quantity;
            Price        = importWithMedication.Price;
        }
    }
}
