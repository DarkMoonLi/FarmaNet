using FarmaNetBackend.Dto.MedicationTypeDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmaNetBackend.Controllers
{
    public class MedicationTypeController : Controller
    {
        private readonly IMedicationTypeRepository _repository;

        public MedicationTypeController(IMedicationTypeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("medicationTypes")]
        public IActionResult GetImports()
        {
            List<MedicationTypeDto> medicationTypes = _repository.GetMedicationTypes().ConvertAll(m => new MedicationTypeDto(m));
            return Ok(medicationTypes);
        }

        [HttpGet]
        [Route("medicationType")]
        public IActionResult GetImport(GetMedicationTypeDto medicationTypeDto)
        {
            MedicationType medicationType = _repository.GetMedicationTypeById(medicationTypeDto);

            if (medicationType == null)
            {
                return NotFound();
            }

            return Ok(medicationType);
        }

        [HttpPost]
        [Route("medicationTypes/add")]
        public IActionResult AddImport(AddMedicationTypeDto medicationTypeDto)
        {
            _repository.AddMedicationType(medicationTypeDto);
            return Ok();
        }

        [HttpPost]
        [Route("medicationTypes/update")]
        public IActionResult UpdateImport(UpdateMedicationTypeDto medicationTypeDto)
        {
            _repository.UpdateMedicationType(medicationTypeDto);
            return Ok();
        }

        [HttpDelete]
        [Route("medicationTypes")]
        public IActionResult RemoveImport(GetMedicationTypeDto medicationTypeDto)
        {
            _repository.RemoveMedicationType(medicationTypeDto);
            return Ok();
        }
    }
}
