using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.ManufacturerDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface IManufacturerRepository
    {
        public List<Manufacturer> GetManufacturers();
        public Manufacturer GetManufacturerById(GetManufacturerDto manufacturerDto);
        public void AddManufacturer(AddManufacturerDto manufacturerDto);
        public void UpdateManufacturer(UpdateManufacturerDto manufacturerDto);
        public void RemoveManufacturer(GetManufacturerDto manufacturerDto);
    }
}
