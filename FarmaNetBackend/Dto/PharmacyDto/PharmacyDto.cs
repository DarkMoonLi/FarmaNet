using FarmaNetBackend.Models.Pharmacy;

namespace FarmaNetBackend.Dto.PharmacyDto
{
    public class PharmacyDto
    {
        public int IdPharmacy { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Descripiton { get; set; }

        public PharmacyDto(Pharmacy pharmacy)
        {
            
        }
    }
}