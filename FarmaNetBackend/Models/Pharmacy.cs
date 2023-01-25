namespace FarmaNetBackend.Domain.Models
{
    public class Pharmacy
    {
        private int _idPharmacy;
        private string _name;
        private string _adress;
        private string _email;
        private string _description;

        public Pharmacy(string name, string adress, string email = "", string description = "")
        {
            _name = name;
            _adress = adress;
            _email = email;
            _description = description;
        }

        public int GetId()
        {
            return _idPharmacy;
        }

        public string GetName()
        {
            return _name;
        }

        public Pharmacy SetName(string name)
        {
            _name = name;

            return this;
        }

        public string GetAdress()
        {
            return _adress;
        }

        public Pharmacy SetAdress(string adress)
        {
            _adress = adress;

            return this;
        }

        public string GetEmail()
        {
            return _email;
        }

        public Pharmacy SetEmail(string email)
        {
            _email = email;

            return this;
        }

        public string GetDescription()
        {
            return _description;
        }

        public Pharmacy SetDescription(string description)
        {
            _description = description;

            return this;
        }

        public Pharmacy SaveInDB()
        {
              
            return this;
        }
    }
}
