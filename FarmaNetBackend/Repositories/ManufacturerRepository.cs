using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.ManufacturerDto;
using FarmaNetBackend.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Repositories
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        readonly ApplicationDbContext _context;

        public ManufacturerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Manufacturer> GetManufacturers()
        {
            return _context.Manufacturers.ToList();
        }

        public Manufacturer GetManufacturerById(GetManufacturerDto manufacturerDto)
        {
            return _context.Manufacturers.FirstOrDefault(m => m.ManufacturerId == manufacturerDto.ManufacturerId);
        }

        public void AddManufacturer(AddManufacturerDto manufacturerDto)
        {
            Manufacturer manufacturer = manufacturerDto.ConvertToManufacturer();

            _context.Manufacturers.Add(manufacturer);
            _context.SaveChanges();
        }

        public void UpdateManufacturer(UpdateManufacturerDto manufacturerDto)
        {
            Manufacturer manufacturer = GetManufacturerById(new GetManufacturerDto{ ManufacturerId = manufacturerDto.ManufacturerId });

            if (manufacturer != null)
            {
                manufacturer.Address = manufacturerDto.Address;
                manufacturer.Name = manufacturerDto.Name;

                _context.SaveChanges();
            }
        }

        public void RemoveManufacturer(GetManufacturerDto manufacturerDto)
        {
            Manufacturer manufacturer = GetManufacturerById(manufacturerDto);

            if (manufacturer != null)
            {
                _context.Manufacturers.Remove(manufacturer);
                _context.SaveChanges();
            }
        }
    }
}