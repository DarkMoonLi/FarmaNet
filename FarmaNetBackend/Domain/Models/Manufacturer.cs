using System.Collections.Generic;

namespace FarmaNetBackend.Models.Manufacturer
{
    public class Manufacturer
    {
        public int _idManufacturer;
        public string _name;
        public string _address;

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
