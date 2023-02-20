using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.PharmacyDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IPharmacyRepository
    {
        public List<Pharmacy> GetPharmacies();
        public Pharmacy GetPharmacyById(int id);
        public void AddPharmacy(PharmacyDto pharmacyDto);
        public void UpdatePharmacy(PharmacyDto pharmacyDto);
        public void RemovePharmacy(int id);
    }
}
