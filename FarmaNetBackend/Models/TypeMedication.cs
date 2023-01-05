using System.Collections.Generic;

namespace FarmaNetBackend.Models
{
    public class TypeMedication
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Medication> Medications { get; set; }

        /*public TypeMedication(string name)
        {
            Name = name;
        }*/
  }
}