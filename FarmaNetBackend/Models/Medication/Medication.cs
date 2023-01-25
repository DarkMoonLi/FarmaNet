namespace FarmaNetBackend.Models.Medication
{
    public class Medication
    {
        private int m_idMedication;
        private string m_name;
        private string m_recipie;
        private int m_idMedicationType;

        public Medication(string name, string recipie, int idMedicationType)
        {
            m_name = name;
            m_recipie = recipie;
            m_idMedicationType = idMedicationType;
        }

        public string GetName()
        {
            return m_name;
        }

        public string GetRecipie()
        {
            return m_recipie;
        }

        public int GetId()
        {
            return m_idMedication;
        }

        public int GetTypeId()
        {
            return m_idMedicationType;
        }
    }
}
