using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaNetBackend.Models
{
    public class Medication
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Recipe { get; set; }
        public int IdMedicationType{ get; set; }

        public TypeMedication TypeMedication { get; set; }
        public List<MedicationWithManufacturer> Medications { get; set; }

        /*public Medication()
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

        public TypeMedication GetTypeMedication()
        {
            return TypeMedication;
        }*/
    }
}
