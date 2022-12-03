namespace FarmaNetBackend.Models.Medication
{
    public class Medication
    {
        private int Id;
        private string Name;
        private string Recipe;
        public int IdMedicationType;

        public Medication(string name, string recipe, int idMedicationType)
        {
            Name = name;
            Recipe = recipe;
            IdMedicationType = idMedicationType;
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
    }
}
