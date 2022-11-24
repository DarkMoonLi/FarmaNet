using FarmaNetBackend.Domain.IRepositories;
using Microsoft.AspNetCore.Mvc;
using FarmaNetBackend.Dto.MedicationDto;
using FarmaNetBackend.Models.Medication;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using FarmaNetBackend;

namespace HelloMvcApp.Controllers
{
    public class MedicationController : Controller
    {

        private readonly IMedicationRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public MedicationController(IMedicationRepository repository, IUnitOfWork unitOfWork )
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route( "medications" )]
        public IActionResult GetMedications()
        {
            List<MedicationDto> medications = _repository.GetMedications().ConvertAll( r => r.ConvertToMedicationDto() );
            return Ok( medications );
        }

        [HttpGet]
        [ProducesResponseType( StatusCodes.Status200OK, Type = typeof( MedicationDto ) )]
        [ProducesResponseType( StatusCodes.Status404NotFound )]
        [Route( "{id:int}" )]
        public IActionResult GetMedicationById( int id )
        {
            Medication medication = _repository.GetMedicationById( id );
            if ( medication == null )
            {
                return NotFound();
            }
            return Ok( medication.ConvertToMedicationDtoById() );
        }

        [HttpPost]
        [Route( "" )]
        public IActionResult AddRecipe( [FromBody] MedicationDto medicationDto )
        {
            _repository.AddMedication( medicationDto );
            _unitOfWork.Commit();
            return Ok();
        }

        [HttpDelete]
        [Route( "{id:int}" )]
        public IActionResult DeleteMedication( int id )
        {
            _repository.DeleteMedication( id );
            _unitOfWork.Commit();
            return Ok();
        }
    }
}