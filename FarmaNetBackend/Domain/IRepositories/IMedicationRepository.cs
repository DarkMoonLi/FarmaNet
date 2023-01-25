using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.MedicationDto;
using System.Collections.Generic;

public interface IMedicationRepository
{
    public List<Medication> GetMedications();
    public Medication GetMedicationById( int id );
    public void AddMedication( MedicationDto medicationDto );
    public void DeleteMedication( int id );
}