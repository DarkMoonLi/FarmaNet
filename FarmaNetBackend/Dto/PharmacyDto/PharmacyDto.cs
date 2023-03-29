using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Http;

namespace FarmaNetBackend.Dto.PharmacyDto
{
    public class PharmacyDto
    {
        public int PharmacyId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Descripiton { get; set; }
        public int PharmacyImageId { get; set; }
        public string ImageTitle { get; set; }
        public string ImagePath { get; set; }

        public PharmacyDto(Pharmacy pharmacy)
        {
            this.PharmacyId      = pharmacy.PharmacyId;
            this.Name            = pharmacy.Name;
            this.Adress          = pharmacy.Address;
            this.Email           = pharmacy.Email;
            this.Descripiton     = pharmacy.Description;
            this.PharmacyImageId = pharmacy.PharmacyImageId;
        }
    }
}