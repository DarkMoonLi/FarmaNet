namespace FarmaNetBackend.Models.Pharmacy
{
    public class Pharmacy
    {
        private int _idPharmacy { get; set; }
        private string _name { get; set; }
        private string _address { get; set; }
        private string _email { get; set; }
        private string _description { get; set; }
        public Pharmacy()
        {
        }

        public Pharmacy(string name, string address, string email, string description)
        {
            _name = name;
            _address = address;
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
            return _address;
        }

        public Pharmacy SetAdress(string adress)
        {
            _address = adress;

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
