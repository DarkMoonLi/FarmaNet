namespace FarmaNetBackend.Models.Manufacturer
{
    public class Manufacturer
    {
        private int m_idManufacturer;
        private string m_name;
        private string m_adress;

        public Manufacturer(string name, string adress)
        {
            m_name = name;
            m_adress = adress;
        }

        public int GetId()
        {
            return m_idManufacturer;
        }

        public string GetName()
        {
            return m_name;
        }

        public Manufacturer SetName(string name)
        {
            m_name = name;

            return this;
        }

        public string GetAdress()
        {
            return m_adress;
        }

        public Manufacturer SetAdress(string adress)
        {
            m_adress = adress;

            return this;
        }
    }
}
