using FarmaNetBackend.Models;

namespace FarmaNetBackend.Dto.Manufacturer
{   
    public class ManufacturerDto
    {
        public int IdManufacturer { get; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ManufacturerDto(FarmaNetBackend.Models.Manufacturer manufacturer)
        {
            //IdManufacturer = manufacturer.GetId();
            //Name = manufacturer.GetName();
            //Address = manufacturer.GetAddress();
        }
    }
}
