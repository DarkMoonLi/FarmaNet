using FarmaNetBackend.Dto.MedicationTypeDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmaNetBackend.Controllers
{
    [ApiController]
    public class MedicationTypeController : Controller
    {
        private readonly IMedicationTypeRepository _repository;

        public MedicationTypeController(IMedicationTypeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("medicationTypes")]
        public IActionResult GetMedicationTypes()
        {
            List<MedicationTypeDto> medicationTypes = _repository.GetMedicationTypes().ConvertAll(r => new MedicationTypeDto(r));
            return Ok(medicationTypes);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MedicationTypeDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Route("medicationType")]
        public IActionResult GetMedicationTypeById(GetMedicationTypeDto medicationTypeDto)
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
        public IActionResult AddMedicationType(AddMedicationTypeDto medicationTypeDto)
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
        public IActionResult DeleteMedicationType(GetMedicationTypeDto medicationTypeDto)
        {
            _repository.RemoveMedicationType(medicationTypeDto);
            return Ok();
        }
    }
}
