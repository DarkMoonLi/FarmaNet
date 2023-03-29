using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.PharmacyDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IPharmacyRepository
    {
        public List<PharmacyDto> GetPharmacies();
        public PharmacyDto GetPharmacyById(int id);
        public void AddPharmacy(AddPharmacyDto pharmacyDto);
        //public void UpdatePharmacy(UpdatePharmacyDto pharmacyDto);
        //public void RemovePharmacy(GetPharmacyDto pharmacyDto);
    }
}
