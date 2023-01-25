using System.Collections.Generic;

namespace FarmaNetBackend.Models.Medication
{
  public class TypeMedication
  {
    public int Id;
    public string Name;
    public List<Medication> Medications = new List<Medication>();

    public TypeMedication(string name)
    {
      Name = name;
    }
  }
}