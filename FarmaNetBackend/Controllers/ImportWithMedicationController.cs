using FarmaNetBackend.Dto.ImportWithMedicationDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Validation;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmaNetBackend.Controllers
{
    public class ImportWithMedicationController : Controller
    {
        private readonly IImportWithMedicationRepository _repository;

        public ImportWithMedicationController(IImportWithMedicationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("importWithMedications")]
        public IActionResult GetImportWithMedications()
        {
            List<ImportWithMedicationDto> importWithMedications = _repository.GetImportWithMedications().ConvertAll(m => new ImportWithMedicationDto(m));
            return Ok(importWithMedications);
        }

        [HttpGet]
        [Route("importWithMedication")]
        public IActionResult GetImportWithMedication(GetImportWithMedicationDto importWithMedicationDto)
        {
            ImportWithMedication importWithMedication = _repository.GetImportWithMedicationById(importWithMedicationDto);

            if (importWithMedication == null)
            {
                return NotFound();
            }

            return Ok(importWithMedication);
        }

        [HttpPost]
        [Route("importWithMedications/add")]
        public IActionResult AddImportWithMedication(AddImportWithMedicationDto importWithMedicationDto)
        {
            QuantityValidator.Validate(importWithMedicationDto.Quantity, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest( ModelStateError.Errors(ModelState) );
            }

            _repository.AddImportWithMedication(importWithMedicationDto);
            return Ok();
        }

        [HttpPost]
        [Route("importWithMedications/update")]
        public IActionResult UpdateImportWithMedication(UpdateImportWithMedicationDto importWithMedicationDto)
        {
            QuantityValidator.Validate(importWithMedicationDto.Quantity, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest( ModelStateError.Errors(ModelState) );
            }

            _repository.UpdateImportWithMedication(importWithMedicationDto);
            return Ok();
        }

        [HttpDelete]
        [Route("importWithMedications")]
        public IActionResult RemoveImportWithMedication(GetImportWithMedicationDto importWithMedicationDto)
        {
            _repository.RemoveImportWithMedication(importWithMedicationDto);
            return Ok();
        }
    }
}
