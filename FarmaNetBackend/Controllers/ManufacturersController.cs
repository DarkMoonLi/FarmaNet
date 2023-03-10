using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Domain.IRepositories;
using FarmaNetBackend.Dto.ManufacturerDto;
using FarmaNetBackend.Domain.UnitOfWork;

namespace FarmaNetBackend.Controllers
{
    public class ManufacturersController : Controller
    {
        private readonly IManufacturerRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public ManufacturersController(IManufacturerRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("manufacturers")]
        public IActionResult GetManufacturers()
        {
            List<ManufacturerDto> manufacturers = _repository.GetManufacturers().ConvertAll(m => new ManufacturerDto(m));
            return Ok(manufacturers);
        }

        [HttpGet]
        [Route("manufacturers/{id:int}")]
        public IActionResult GetManufacturer(int id)
        {
            Manufacturer manufacturer = _repository.GetManufacturerById(id);

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
        [Route("manufacturers/{id:int}")]
        public IActionResult RemoveManufacturer(int id)
        {
            _repository.RemoveManufacturer(id);
            return Ok();
        }
    }
}