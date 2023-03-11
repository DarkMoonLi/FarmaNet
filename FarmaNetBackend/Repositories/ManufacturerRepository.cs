﻿using FarmaNetBackend.IRepositories;
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
            List<Manufacturer> manufacturers = _context.Manufacturers.ToList();

            return manufacturers;
        }

        public Manufacturer GetManufacturerById(int id)
        {
            Manufacturer manufacturer = _context.Manufacturers.FirstOrDefault(m => m.ManufacturerId == id);

            return manufacturer;
        }

        public void AddManufacturer(AddManufacturerDto manufacturerDto)
        {
            Manufacturer manufacturer = manufacturerDto.ConvertToManufacturer();

            _context.Manufacturers.Add(manufacturer);
            _context.SaveChanges();
        }

        public void UpdateManufacturer(UpdateManufacturerDto manufacturerDto)
        {
            Manufacturer manufacturer = _context.Manufacturers.FirstOrDefault(m => m.ManufacturerId == manufacturerDto.ManufacturerId);

            if (manufacturer != null)
            {
                manufacturer.Address = manufacturerDto.Address;
                manufacturer.Name = manufacturerDto.Name;

                _context.SaveChanges();
            }
        }

        public void RemoveManufacturer( int id )
        {
            Manufacturer manufacturer = _context.Manufacturers.FirstOrDefault(m => m.ManufacturerId == id);

            if (manufacturer != null)
            {
                _context.Manufacturers.Remove(manufacturer);
                _context.SaveChanges();
            }
        }
    }

    public static class ConvertManufacturer
    {
        public static ManufacturerDto ConvertToManufacturerDto( this Manufacturer manufacturer)
        {
            return new ManufacturerDto(manufacturer);
        }
    }
}