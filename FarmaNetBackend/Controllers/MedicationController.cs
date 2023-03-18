using Microsoft.AspNetCore.Mvc;
using FarmaNetBackend.Dto.MedicationDto;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Repositories;

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
        [Route("medications")]
        public IActionResult GetMedications()
        {
            List<MedicationDto> medications = _repository.GetMedications().ConvertAll( r => new MedicationDto(r) );
            return Ok( medications );
        }

        [HttpGet]
        //[ProducesResponseType( StatusCodes.Status200OK, Type = typeof( MedicationDto ) )]
        //[ProducesResponseType( StatusCodes.Status404NotFound )]
        [Route("medication")]
        public IActionResult GetMedicationById(GetMedicationDto medicationDto)
        {
            Medication medication = _repository.GetMedicationById(medicationDto);
            
            if ( medication == null )
            {
                return NotFound();
            }

            return Ok( medication.ConvertToMedicationDto() );
        }

        [HttpPost]
        [Route( "add" )]
        public IActionResult AddMedication(AddMedicationDto medicationDto)
        {
            _repository.AddMedication(medicationDto);
            return Ok();
        }

        [HttpDelete]
        [Route( "medications" )]
        public IActionResult DeleteMedication(GetMedicationDto medicationDto)
        {
            _repository.DeleteMedication(medicationDto);
            return Ok();
        }
    }
}