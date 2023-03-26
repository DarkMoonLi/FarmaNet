using FarmaNetBackend.Dto.PharmacyWithMedicationDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Validation;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmaNetBackend.Controllers
{
    public class PharmacyWithMedicationController : Controller
    {
        private readonly IPharmacyWithMedicationRepository _repository;

        public PharmacyWithMedicationController(IPharmacyWithMedicationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("pharmacyWithMedications")]
        public IActionResult GetPharmacyWithMedications()
        {
            List<PharmacyWithMedicationDto> pharmacyWithMedications = _repository.GetPharmacyWithMedications().ConvertAll(m => new PharmacyWithMedicationDto(m));
            return Ok(pharmacyWithMedications);
        }

        [HttpGet]
        [Route("pharmacyWithMedication")]
        public IActionResult GetPharmacyWithMedication(GetPharmacyWithMedicationDto pharmacyWithMedicationDto)
        {
            PharmacyWithMedication pharmacyWithMedication = _repository.GetPharmacyWithMedicationById(pharmacyWithMedicationDto);

            if (pharmacyWithMedication == null)
            {
                return NotFound();
            }

            return Ok(pharmacyWithMedication);
        }

        [HttpPost]
        [Route("pharmacyWithMedications/add")]
        public IActionResult AddPharmacyWithMedication(AddPharmacyWithMedicationDto pharmacyWithMedicationDto)
        {
            QuantityValidator.Validate(pharmacyWithMedicationDto.Quantity, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest( ModelStateError.Errors(ModelState) );
            }

            _repository.AddPharmacyWithMedication(pharmacyWithMedicationDto);
            return Ok();
        }

        [HttpPost]
        [Route("pharmacyWithMedications/update")]
        public IActionResult UpdatePharmacyWithMedication(UpdatePharmacyWithMedicationDto pharmacyWithMedicationDto)
        {
            QuantityValidator.Validate(pharmacyWithMedicationDto.Quantity, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest( ModelStateError.Errors(ModelState) );
            }

            _repository.UpdatePharmacyWithMedication(pharmacyWithMedicationDto);
            return Ok();
        }

        [HttpDelete]
        [Route("pharmacyWithMedications")]
        public IActionResult RemovePharmacyWithMedication(GetPharmacyWithMedicationDto pharmacyWithMedicationDto)
        {
            _repository.RemovePharmacyWithMedication(pharmacyWithMedicationDto);
            return Ok();
        }
    }
}
