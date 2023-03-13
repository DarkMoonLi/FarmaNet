using FarmaNetBackend.Dto.ImportWithMedicationDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
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
        public IActionResult GetImports()
        {
            List<ImportWithMedicationDto> importWithMedications = _repository.GetImportWithMedications().ConvertAll(m => new ImportWithMedicationDto(m));
            return Ok(importWithMedications);
        }

        [HttpGet]
        [Route("importWithMedication")]
        public IActionResult GetImport(GetImportWithMedicationDto importWithMedicationDto)
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
        public IActionResult AddImport(AddImportWithMedicationDto importWithMedicationDto)
        {
            _repository.AddImportWithMedication(importWithMedicationDto);
            return Ok();
        }

        [HttpPost]
        [Route("importWithMedications/update")]
        public IActionResult UpdateImport(UpdateImportWithMedicationDto importWithMedicationDto)
        {
            _repository.UpdateImportWithMedication(importWithMedicationDto);
            return Ok();
        }

        [HttpDelete]
        [Route("importWithMedications")]
        public IActionResult RemoveImport(GetImportWithMedicationDto importWithMedicationDto)
        {
            _repository.RemoveImportWithMedication(importWithMedicationDto);
            return Ok();
        }
    }
}
