using FarmaNetBackend.Domain.IRepositories;
using Microsoft.AspNetCore.Mvc;
using FarmaNetBackend.Dto.MedicationDto;
using FarmaNetBackend.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using FarmaNetBackend.Models.Medication;
using FarmaNetBackend.Infrastructure.Repositories;

namespace FarmaNetBackend.Controllers
{
    [ApiController]
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
        [Route( "/" )]
        public IActionResult GetMedications()
        {
            List<MedicationDto> medications = _repository.GetMedications().ConvertAll( r => new MedicationDto(r) );
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
            return Ok(medication.ConvertToMedicationDtoById() );
        }

        [HttpPost]
        [Route( "add" )]
        public IActionResult AddMedication( [FromBody] MedicationDto medicationDto )
        {
            Medication medication = new Medication("яд", "Y", 1, new TypeMedication());
            _repository.AddMedication( medication.ConvertToMedicationDto() );
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