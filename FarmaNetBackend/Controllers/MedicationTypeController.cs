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
        private readonly IUnitOfWork _unitOfWork;

        public MedicationTypeController(IMedicationTypeRepository repository)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
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
        public IActionResult GetMedicationTypeById(int id)
        {
            MedicationType medicationType = _repository.GetMedicationTypeById(id);
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
        [Route("medicationType/delete/{id:int}")]
        public IActionResult DeleteMedicationType(int id)
        {
            _repository.RemoveMedicationType(id);
            _unitOfWork.Commit();
            return Ok();
        }
    }
}
