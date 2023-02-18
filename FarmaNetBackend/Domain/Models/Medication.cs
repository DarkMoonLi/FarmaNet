using System;

namespace FarmaNetBackend.Models.Medication
{
    public class Medication
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _recipe { get; set; }
        public int _idMedicationType { get; set; }
        public TypeMedication _typeMedication { get; set; }

        public Medication()
        {
        }

        public Medication(string name, string recipe, int idMedicationType, TypeMedication typeMedication)
        {
            _name = name;
            _recipe = recipe;
            _idMedicationType = idMedicationType;
            _typeMedication = typeMedication;
        }
    }
}
