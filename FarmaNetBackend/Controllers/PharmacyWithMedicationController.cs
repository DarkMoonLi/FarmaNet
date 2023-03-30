using FarmaNetBackend.Dto.PharmacyWithMedicationDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Validation;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpGet]
        [Route("pharmacyWithMedicationsByPharmacy/{id}")]
        public IActionResult GetMedicationsInPharmacy(int id)
        {
            List<PharmacyWithMedication> medications = _repository.GetMedicationsInPharmacy(id);  

            return Ok(medications);
        }

        [HttpGet]
        [Route("pharmacyWithMedicationByMedication/{id}")]
        public IActionResult GetPharmaciesWithMedication(int id)
        {
            List<PharmacyWithMedication> medications = _repository.GetPharmaciesWithMedicaion(id);

            return Ok(medications);
        }

        [HttpPost]
        [Route("pharmacyWithMedications/add")]
        public IActionResult AddPharmacyWithMedication(AddPharmacyWithMedicationDto pharmacyWithMedicationDto)
        {
            QuantityValidator.Validate(pharmacyWithMedicationDto.Quantity, ModelState);
            SumValidator.Validate(pharmacyWithMedicationDto.Price, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest( ModelStateError.Errors(ModelState) );
            }

            try
            {
                _repository.AddPharmacyWithMedication(pharmacyWithMedicationDto);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("pharmacyWithMedications/update")]
        public IActionResult UpdatePharmacyWithMedication(UpdatePharmacyWithMedicationDto pharmacyWithMedicationDto)
        {
            QuantityValidator.Validate(pharmacyWithMedicationDto.Quantity, ModelState);
            SumValidator.Validate(pharmacyWithMedicationDto.Price, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest( ModelStateError.Errors(ModelState) );
            }

            try
            {
                _repository.UpdatePharmacyWithMedication(pharmacyWithMedicationDto);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
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
