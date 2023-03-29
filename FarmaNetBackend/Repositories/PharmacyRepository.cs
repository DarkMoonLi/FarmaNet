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

        public List<PharmacyDto> GetPharmacies()
        {
            List<Pharmacy> pharmacies = _context.Pharmacies.ToList();

            List<PharmacyDto> result = ConvertPharmacies(pharmacies);

            return result;
        }

        public PharmacyDto GetPharmacyById(int id)
        {
            Pharmacy pharmacy = _context.Pharmacies.FirstOrDefault(p => p.PharmacyId == id);

            if (pharmacy != null)
            {
                PharmacyDto result = ConvertPharmacy(pharmacy);

                return result;
            }

            return null;
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

        private List<PharmacyDto> ConvertPharmacies(List<Pharmacy> pharmacies)
        {
            List<PharmacyDto> result = new List<PharmacyDto>();

            foreach (Pharmacy pharmacy in pharmacies)
            {
                PharmacyDto pharmacyDto = ConvertPharmacy(pharmacy);

                result.Add(pharmacyDto);
            }

            return result;
        }

        private PharmacyDto ConvertPharmacy(Pharmacy pharmacy)
        {
            PharmacyDto result = new PharmacyDto(pharmacy);

            PharmacyImage image = _context.PharmacyImages.FirstOrDefault(i => i.ImageId.Equals(pharmacy.PharmacyImageId));

            if (image != null)
            {
                result.ImageTitle = image.Title;
                result.ImagePath = image.Path;
            }

            return result;
        }
    }
}
