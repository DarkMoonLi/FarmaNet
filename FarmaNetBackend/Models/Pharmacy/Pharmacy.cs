namespace FarmaNetBackend.Models.Pharmacy
{
    public class Pharmacy
    {
        private int m_idPharmacy;
        private string m_name;
        private string m_adress;
        private string m_email;
        private string m_description;

        public Pharmacy(string name, string adress, string email = "", string description = "")
        {
            m_name = name;
            m_adress = adress;
            m_email = email;
            m_description = description;
        }

        public int GetId()
        {
            return m_idPharmacy;
        }

        public string GetName()
        {
            return m_name;
        }

        public Pharmacy SetName(string name)
        {
            m_name = name;

            return this;
        }

        public string GetAdress()
        {
            return m_adress;
        }

        public Pharmacy SetAdress(string adress)
        {
            m_adress = adress;

            return this;
        }

        public string GetEmail()
        {
            return m_email;
        }

        public Pharmacy SetEmail(string email)
        {
            m_email = email;

            return this;
        }

        public string GetDescription()
        {
            return m_description;
        }

        public Pharmacy SetDescription(string descriptipon)
        {
            m_description = descriptipon;

            return this;
        }

        public Pharmacy SaveInDB()
        {
              
            return this;
        }
    }
}
