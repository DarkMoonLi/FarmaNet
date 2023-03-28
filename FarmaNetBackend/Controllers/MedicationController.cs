using Microsoft.AspNetCore.Mvc;
using FarmaNetBackend.Dto.MedicationDto;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Repositories;
using FarmaNetBackend.Validation;

namespace FarmaNetBackend.Controllers
{
    [ApiController]
    public class MedicationController : Controller
    {
        private readonly IMedicationRepository _repository;
        
        public MedicationController(IMedicationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("drugs")]
        public IActionResult GetMedications()
        {
            List<MedicationDto> medications = _repository.GetMedications().ConvertAll( r => new MedicationDto(r) );
            return Ok( medications );
        }

        [HttpGet]
        [Route("medicationsByName/{name}")]
        public IActionResult GetMedicationByName(string name)
        {
            List<Medication> medication = _repository.GetMedicationsByName(name);

            if (medication == null)
            {
                return NotFound();
            }

            return Ok(medication);
        }

        [HttpGet]
        [Route("medicationsByType/{medicationTypeId}")]
        public IActionResult GetMedicationByMedicationType(int medicationTypeId)
        {
            List<Medication> medication = _repository.GetMedicationsByType(medicationTypeId);

            if (medication == null)
            {
                return NotFound();
            }

            return Ok(medication);
        }

        [HttpGet]
        [Route("drugs/{id}")]
        public IActionResult GetMedicationByPharmacyId(int id)
        {
            List<Medication> medication = _repository.GetMedicationsByPharmacyId(id);

            if (medication == null)
            {
                return NotFound();
            }

            return Ok(medication);
        }

        [HttpGet]
        [Route("drug/{id}")]
        public IActionResult GetMedicationById(int id)
        {
            Medication medication = _repository.GetMedicationById(id);
            
            if ( medication == null )
            {
                return NotFound();
            }

            return Ok( new MedicationDto(medication) );
        }

        [HttpPost]
        [Route( "drugs/add" )]
        public IActionResult AddMedication(AddMedicationDto medicationDto)
        {
            NameValidator.Validate(medicationDto.Name, ModelState);
            DescriptionValidator.Validate(medicationDto.Contraindications, ModelState);
            DescriptionValidator.Validate(medicationDto.Instruction, ModelState);
            DescriptionValidator.Validate(medicationDto.Composition, ModelState);
            DescriptionValidator.Validate(medicationDto.IndicationsForUse, ModelState);

            if (ModelState.IsValid)
            {
                _repository.AddMedication(medicationDto);
                return Ok();
            }
            
            return BadRequest( ModelStateError.Errors(ModelState) );
        }
        
        [HttpPost]
        [Route("drugs/update")]
        /*public IActionResult UpdateMedication(UpdateMedicationDto medicationDto)
        {
            NameValidator.Validate(medicationDto.Name, ModelState);
            DescriptionValidator.Validate(medicationDto.Contraindications, ModelState);
            DescriptionValidator.Validate(medicationDto.Instruction, ModelState);
            DescriptionValidator.Validate(medicationDto.Composition, ModelState);
            DescriptionValidator.Validate(medicationDto.IndicationsForUse, ModelState);

            if (ModelState.IsValid)
            {
                _repository.UpdateMedication(medicationDto);
                return Ok();
            }

            return BadRequest( ModelStateError.Errors(ModelState) );
        }*/

        [HttpDelete]
        [Route( "drugs/delete" )]
        public IActionResult DeleteMedication(int id)
        {
            _repository.DeleteMedication(id);
            return Ok();
        }
    }
}