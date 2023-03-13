using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FarmaNetBackend.Models;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Dto.ManufacturerDto;

namespace FarmaNetBackend.Controllers
{
  public class ManufacturersController : Controller
    {
        private readonly IManufacturerRepository _repository;
        
        public ManufacturersController(IManufacturerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("manufacturers")]
        public IActionResult GetManufacturers()
        {
            List<ManufacturerDto> manufacturers = _repository.GetManufacturers().ConvertAll(m => new ManufacturerDto(m));
            return Ok(manufacturers);
        }

        [HttpGet]
        [Route("manufacturer")]
        public IActionResult GetManufacturer(GetManufacturerDto manufacturerDto)
        {
            Manufacturer manufacturer = _repository.GetManufacturerById(manufacturerDto);

            if (manufacturer == null)
            {
                return NotFound();
            }

            return Ok(manufacturer);
        }

        [HttpPost]
        [Route("manufacturers/add")]
        public IActionResult AddManufacturer(AddManufacturerDto manufacturerDto)
        {
            _repository.AddManufacturer(manufacturerDto);
            return Ok();
        }

        [HttpPost]
        [Route("manufacturers/update")]
        public IActionResult UpdateManufacturer(UpdateManufacturerDto manufacturerDto)
        {
            _repository.UpdateManufacturer(manufacturerDto);
            return Ok();
        }

        [HttpDelete]
        [Route("manufacturers")]
        public IActionResult RemoveManufacturer(GetManufacturerDto manufacturerDto)
        {
            _repository.RemoveManufacturer(manufacturerDto);
            return Ok();
        }
    }
}