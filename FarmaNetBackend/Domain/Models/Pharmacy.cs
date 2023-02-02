using System.Collections.Generic;

namespace FarmaNetBackend.Domain.Models
{
    public class Pharmacy
    {
        public int _idPharmacy { get; set; }
        public string _name { get; set; }
        public string _adress { get; set; }
        public string _email { get; set; }
        public string _description { get; set; }

        public virtual List<WorkerAccount> WorkerAccounts { get; set; }
        public virtual List<WriteDowns> WriteDowns { get; set; }
        public virtual List<Import> Imports { get; set; }
        public virtual List<PharmacyWithMedication> PharmacyWithMedications { get; set; }
        public virtual List<Sale> Sales { get; set; }

        /*
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
        */
    }
}
