using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.ManufacturerDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface IManufacturerRepository
    {
        public List<Manufacturer> GetManufacturers();
        public Manufacturer GetManufacturerById(int id);
        public void AddManufacturer(AddManufacturerDto manufacturerDto);
        public void UpdateManufacturer(UpdateManufacturerDto manufacturerDto);
        public void RemoveManufacturer(int id);
    }
}
