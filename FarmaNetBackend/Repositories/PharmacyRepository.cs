using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.PharmacyDto;
using FarmaNetBackend.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Repositories
{
    public class PharmacyRepository : IPharmacyRepository
    {
        ApplicationDbContext _context;

        public PharmacyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Pharmacy> GetPharmacies()
        {
            return _context.Pharmacies.ToList();
        }

        public Pharmacy GetPharmacyById(int id)
        {
            return _context.Pharmacies.FirstOrDefault(p => p.PharmacyId == id);
        }

        public void AddPharmacy(AddPharmacyDto pharmacyDto)
        {
            Pharmacy pharmacy = pharmacyDto.ConvertToPharmacy();

            _context.Pharmacies.Add(pharmacy);
            _context.SaveChanges();
        }

        /*public void UpdatePharmacy(UpdatePharmacyDto pharmacyDto)
        {
            Pharmacy pharmacy = GetPharmacyById(new GetPharmacyDto { PharmacyId = pharmacyDto.PharmacyId });

            if (pharmacy != null)
            {
                pharmacy.Address         = pharmacyDto.Address;
                pharmacy.Name            = pharmacyDto.Name;
                pharmacy.Email           = pharmacyDto.Email;
                pharmacy.Description     = pharmacyDto.Description;
                pharmacy.PharmacyImageId = pharmacyDto.PharmacyImageId;

                _context.Pharmacies.Update(pharmacy);
                _context.SaveChanges();
            }
        }*/

        /*public void RemovePharmacy(GetPharmacyDto pharmacyDto)
        {
            Pharmacy pharmacy = GetPharmacyById(pharmacyDto);

            if (pharmacy != null)
            {
                _context.Pharmacies.Remove(pharmacy);
                _context.SaveChanges();
            }
        }*/
    }
}
