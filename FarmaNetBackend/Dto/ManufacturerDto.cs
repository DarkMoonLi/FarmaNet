using FarmaNetBackend.Domain.Models;

namespace FarmaNetBackend.Dto.ManufacturerDto
{
    public class ManufacturerDto
    {
        public int ManufacturerId { get; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public ManufacturerDto(Manufacturer manufacturer)
        {
            ManufacturerId = manufacturer.ManufacturerId;
            Name           = manufacturer.Name;
            Adress         = manufacturer.Address;
        }
    }
}
