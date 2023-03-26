using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Http;

namespace FarmaNetBackend.Dto.PharmacyDto
{
    public class AddPharmacyDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public int PharmacyImageId { get; set; }

        public Pharmacy ConvertToPharmacy()
        {
            return new Pharmacy
            {
                Name            = this.Name,
                Address         = this.Address,
                Email           = this.Email,
                Description     = this.Description,
                PharmacyImageId = this.PharmacyImageId
            };
        }
    }
}