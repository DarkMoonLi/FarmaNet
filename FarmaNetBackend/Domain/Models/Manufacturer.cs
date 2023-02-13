using System.Data.Entity;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.Models
{
    public class Manufacturer
    {
        public int _idManufacturer { get; set; }
        public string _name { get; set; }
        public string _address { get; set; }

        public virtual List<MedicationWithManufacturer> MedicationWithManufacturers { get; set; }

        /*
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
        */
    }
}
