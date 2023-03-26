namespace FarmaNetBackend.Dto.PharmacyDto
{
    public class UpdatePharmacyDto
    {
        public int PharmacyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public int PharmacyImageId { get; set; }
    }
}