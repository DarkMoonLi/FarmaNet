using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.PharmacyDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IPharmacyRepository
    {
        public List<Pharmacy> GetPharmacies();
        public Pharmacy GetPharmacyById(GetPharmacyDto pharmacyDto);
        public void AddPharmacy(AddPharmacyDto pharmacyDto);
        public void UpdatePharmacy(UpdatePharmacyDto pharmacyDto);
        public void RemovePharmacy(GetPharmacyDto pharmacyDto);
    }
}
