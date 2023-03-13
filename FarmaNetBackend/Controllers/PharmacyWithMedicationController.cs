using FarmaNetBackend.Dto.PharmacyWithMedicationDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
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
        public IActionResult GetImports()
        {
            List<PharmacyWithMedicationDto> pharmacyWithMedications = _repository.GetPharmacyWithMedications().ConvertAll(m => new PharmacyWithMedicationDto(m));
            return Ok(pharmacyWithMedications);
        }

        [HttpGet]
        [Route("pharmacyWithMedication")]
        public IActionResult GetImport(GetPharmacyWithMedicationDto pharmacyWithMedicationDto)
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
        public IActionResult AddImport(AddPharmacyWithMedicationDto pharmacyWithMedicationDto)
        {
            _repository.AddPharmacyWithMedication(pharmacyWithMedicationDto);
            return Ok();
        }

        [HttpPost]
        [Route("pharmacyWithMedications/update")]
        public IActionResult UpdateImport(UpdatePharmacyWithMedicationDto pharmacyWithMedicationDto)
        {
            _repository.UpdatePharmacyWithMedication(pharmacyWithMedicationDto);
            return Ok();
        }

        [HttpDelete]
        [Route("pharmacyWithMedications")]
        public IActionResult RemoveImport(GetPharmacyWithMedicationDto pharmacyWithMedicationDto)
        {
            _repository.RemovePharmacyWithMedication(pharmacyWithMedicationDto);
            return Ok();
        }
    }
}
