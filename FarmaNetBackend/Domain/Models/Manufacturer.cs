using System.Collections.Generic;

namespace FarmaNetBackend.Models.Manufacturer
{
    public class Manufacturer
    {
        public int _idManufacturer { get; set; }
        public string _name { get; set; }
        public string _address { get; set; }

        public Manufacturer(string name, string address)
        {
            _name = name;
            _address = address;
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
