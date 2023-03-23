using FarmaNetBackend.Dto.MedicationWithManufacturerDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmaNetBackend.Controllers
{
    public class MedicationWithManufacturerController : Controller
    {
        private readonly IMedicationWithManufacturerRepository _repository;

        public MedicationWithManufacturerController(IMedicationWithManufacturerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("medicationWithManufacturers")]
        public IActionResult GetMedicationWithManufacturers()
        {
            List<MedicationWithManufacturerDto> medicationWithManufacturers = _repository.GetMedicationWithManufacturers().ConvertAll(m => new MedicationWithManufacturerDto(m));
            return Ok(medicationWithManufacturers);
        }

        [HttpGet]
        [Route("medicationWithManufacturer")]
        public IActionResult GetMedicationWithManufacturer(GetMedicationWithManufacturerDto medicationWithManufacturerDto)
        {
            MedicationWithManufacturer medicationWithManufacturer = _repository.GetMedicationWithManufacturerById(medicationWithManufacturerDto);

            if (medicationWithManufacturer == null)
            {
                return NotFound();
            }

            return Ok(medicationWithManufacturer);
        }

        [HttpPost]
        [Route("medicationWithManufacturers/add")]
        public IActionResult AddMedicationWithManufacturer(AddMedicationWithManufacturerDto medicationWithManufacturerDto)
        {
            _repository.AddMedicationWithManufacturer(medicationWithManufacturerDto);
            return Ok();
        }

        [HttpPost]
        [Route("medicationWithManufacturers/update")]
        public IActionResult UpdateMedicationWithManufacturer(UpdateMedicationWithManufacturerDto medicationWithManufacturerDto)
        {
            _repository.UpdateMedicationWithManufacturer(medicationWithManufacturerDto);
            return Ok();
        }

        [HttpDelete]
        [Route("medicationWithManufacturers")]
        public IActionResult RemoveMedicationWithManufacturer(GetMedicationWithManufacturerDto medicationWithManufacturerDto)
        {
            _repository.RemoveMedicationWithManufacturer(medicationWithManufacturerDto);
            return Ok();
        }
    }
}
