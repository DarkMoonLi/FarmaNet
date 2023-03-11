using FarmaNetBackend.Models;

namespace FarmaNetBackend.Dto.ManufacturerDto
{
    public class AddManufacturerDto
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Manufacturer ConvertToManufacturer()
        {
            return new Manufacturer
            {
                Name = this.Name,
                Address = this.Address
            };
        }
    }
}
