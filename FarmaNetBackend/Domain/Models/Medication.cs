using System.Data.Entity;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.Models
{
    public class Medication
    {
        public int _idMedication { get; set; }
        public string _name { get; set; }
        public string _recipe { get; set; }
        
        //public int _idMedicationType{ get; set; }

        
        public TypeMedication TypeMedication { get; set; }

        
        public virtual List<MedicationWithManufacturer> MedicationWithManufacturers { get; set; }
        public virtual List<ImportWithMedication> ImportWithMedications { get; set; }
        public virtual List<PharmacyWithMedication> PharmacyWithMedications { get; set; }
        public virtual List<WriteDowns> WriteDowns { get; set; }
        public virtual List<Sale> Sales { get; set; }

        /*
        public Medication()
        {
        }

        public Medication(string name, string recipe, int idMedicationType, TypeMedication typeMedication)
        {
            Name = name;
            Recipe = recipe;
            IdMedicationType = idMedicationType;
            TypeMedication = typeMedication;
        }

    public string GetName()
        {
            return Name;
        }

        public string GetRecipe()
        {
            return Recipe;
        }

        public int GetId()
        {
            return Id;
        }

        public int GetTypeId()
        {
            return IdMedicationType;
        }
        */
    }
}
