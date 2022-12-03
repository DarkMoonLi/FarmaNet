namespace FarmaNetBackend.Models.Medication
{
  public class TypeMedication
  {
    public int Id;
    public string Name;

    public TypeMedication(string name)
    {
      Name = name;
    }
  }
}