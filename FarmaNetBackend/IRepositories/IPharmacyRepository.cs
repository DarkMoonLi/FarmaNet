using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.PharmacyDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IPharmacyRepository
    {
        public List<Pharmacy> GetPharmacies();
        public Pharmacy GetPharmacyById(int id);
        public void AddPharmacy(AddPharmacyDto pharmacyDto);
        public void UpdatePharmacy(UpdatePharmacyDto pharmacyDto);
        public void RemovePharmacy(int id);
    }
}
