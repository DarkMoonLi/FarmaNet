using FarmaNetBackend.Domain.IRepositories;
using Microsoft.AspNetCore.Mvc;
using FarmaNetBackend.Dto.MedicationDto;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using FarmaNetBackend.Domain.Models;
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
        [Route( "/medications" )]
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
            return Ok( medication.ConvertToMedicationDto() );
        }

        [HttpPost]
        [Route( "add" )]
        public IActionResult AddMedication( [FromBody] MedicationDto medicationDto )
        {
            _repository.AddMedication(medicationDto);
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