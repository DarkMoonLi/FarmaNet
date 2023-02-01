using FarmaNetBackend.Dto.MedicationDto;
using System.Collections.Generic;
using FarmaNetBackend.Models.Medication;

public interface IMedicationRepository
{
    public List<Medication> GetMedications();
    public Medication GetMedicationById( int id );
    public void AddMedication( MedicationDto medicationDto );
    public void DeleteMedication( int id );
}