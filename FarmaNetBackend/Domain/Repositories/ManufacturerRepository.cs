using FarmaNetBackend.Domain.IRepositories;
using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.ManufacturerDto;
using FarmaNetBackend.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Domain.Repositories
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
            List<Manufacturer> manufacturers = _context.Manufacturers.ToList();

            return manufacturers;
        }

        public Manufacturer GetManufacturerById(int id)
        {
            Manufacturer manufacturer = (Manufacturer)_context.Manufacturers.Where(m => m.ManufacturerId == id);

            return manufacturer;
        }

        public void AddManufacturer( AddManufacturerDto manufacturerDto )
        {
            Manufacturer manufacturer = manufacturerDto.ConvertToManufacturer();

            _context.Manufacturers.Add(manufacturer);
            _context.SaveChanges();
        }

        public void UpdateManufacturer( ManufacturerDto manufacturerDto )
        {
        
        }

        public void RemoveManufacturer( int id )
        {
            Manufacturer manufacturer = _context.Manufacturers.FirstOrDefault(m => m.ManufacturerId == id);

            if (manufacturer != null)
            {
                _context.Manufacturers.Remove(manufacturer);
            }
        }
    }

    public static class ConvertManufacturer
    {
        public static Manufacturer ConvertToManufacturer( this AddManufacturerDto manufacturerDto)
        {
            return new Manufacturer
            {
                Name           = manufacturerDto.Name,
                Address        = manufacturerDto.Address
            };

        }

        public static ManufacturerDto ConvertToManufacturerDto( this Manufacturer manufacturer)
        {
            return new ManufacturerDto(manufacturer);
        }
    }
}