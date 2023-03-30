using FarmaNetBackend.Dto.MedicationTypeDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Validation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
        [Route("/medicationType/all")]
        public IActionResult GetMedicationTypes()
        {
            List<MedicationTypeDto> medicationTypes = _repository.GetMedicationTypes().ConvertAll(r => new MedicationTypeDto(r));
            return Ok(medicationTypes);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MedicationTypeDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Route("medicationType/{id:int}")]
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
        [Route("medicationType/add")]
        public IActionResult AddMedicationType(AddMedicationTypeDto medicationTypeDto)
        {
            NameValidator.Validate(medicationTypeDto.Name, ModelState);

            try
            {
                if (ModelState.IsValid)
                {
                    _repository.AddMedicationType(medicationTypeDto);
                    return Ok();
                }
            }
            catch (Exception e)
            {
                return BadRequest();
            }

            return BadRequest( ModelStateError.Errors(ModelState) );
        }

        [HttpPost]
        [Route("medicationTypes/update")]
        public IActionResult UpdateImport(UpdateMedicationTypeDto medicationTypeDto)
        {
            NameValidator.Validate(medicationTypeDto.Name, ModelState);

            try
            {
                if (ModelState.IsValid)
                {
                    _repository.UpdateMedicationType(medicationTypeDto);
                    return Ok();
                }
            }
            catch (Exception e)
            {
                return BadRequest();
            }

            return BadRequest( ModelStateError.Errors(ModelState) );
        }

        [HttpDelete]
        [Route("medicationType/delete/{id:int}")]
        public IActionResult DeleteMedicationType(GetMedicationTypeDto medicationTypeDto)
        {
            _repository.RemoveMedicationType(medicationTypeDto);
            return Ok();
        }
    }
}
