namespace FarmaNetBackend.Models.Manufacturer
{
    public class Manufacturer
    {
        private int _idManufacturer;
        private string _name;
        private string _address;

        public Manufacturer(string name, string adress)
        {
            _name = name;
            _address = adress;
        }

        public int GetId()
        {
            return _idManufacturer;
        }

        public string GetName()
        {
            return _name;
        }

        public Manufacturer SetName(string name)
        {
            _name = name;

            return this;
        }

        public string GetAdress()
        {
            return _address;
        }

        public Manufacturer SetAdress(string adress)
        {
            _address = adress;

            return this;
        }
    }
}
