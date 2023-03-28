using FarmaNetBackend.Dto.WorkerInformationDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Validation;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmaNetBackend.Controllers
{
    public class WorkerInformationController : Controller
    {
        private readonly IWorkerInformationRepository _repository;

        public WorkerInformationController(IWorkerInformationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("workerInformations")]
        public IActionResult GetWorkerInformations()
        {
            List<WorkerInformationDto> workerInforamtions = _repository.GetWorkerInformations().ConvertAll(m => new WorkerInformationDto(m));
            return Ok(workerInforamtions);
        }

        [HttpGet]
        [Route("workerInformation/{id}")]
        public IActionResult GetWorkerInformation(int id)
        {
            WorkerInformation workerInformation = _repository.GetWorkerInformationById(id);

            if (workerInformation == null)
            {
                return NotFound();
            }

            return Ok(workerInformation);
        }

        [HttpGet]
        [Route("workerPharmacy/{id}")]
        public IActionResult GetPharmacyByWorkerInformationId(int id)
        {
            Pharmacy pharmacy = _repository.GetPharmacyByWorkerInformationId(id);

            if (pharmacy == null)
            {
                return NotFound();
            }

            return Ok(pharmacy);
        }

        [HttpGet]
        [Route("workerPosition/{id}")]
        public IActionResult GetPositionByWorkerInformationId(int id)
        {
            Position workerInformation = _repository.GetPositionByWorkerInformationId(id);

            if (workerInformation == null)
            {
                return NotFound();
            }

            return Ok(workerInformation);
        }

        [HttpPost]
        [Route("workerInformations/add")]
        public IActionResult AddWorkerInformation(AddWorkerInformationDto workerInformationDto)
        {
            NameValidator.Validate(workerInformationDto.Name, ModelState);
            NameValidator.Validate(workerInformationDto.LastName, ModelState);
            EmailValidator.Validate(workerInformationDto.Email, ModelState);
            PassportSeriesValidator.Validate(workerInformationDto.SeriesPassport, ModelState);
            PassportNumberValidator.Validate(workerInformationDto.NumberPassport, ModelState);
            ExperienceValidator.Validate(workerInformationDto.Experience, ModelState);
            DateValidator.Validate(workerInformationDto.DataBirth, ModelState);
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelStateError.Errors(ModelState));
            }

            _repository.AddWorkerInformation(workerInformationDto);
            return Ok();
        }

        //[HttpPost]
        //[Route("workerInformations/update")]
        //public IActionResult UpdateWorkerInformation(UpdateWorkerInformationDto workerInformationDto)
        //{
        //    NameValidator.Validate(workerInformationDto.Name, ModelState);
        //    NameValidator.Validate(workerInformationDto.LastName, ModelState);
        //    EmailValidator.Validate(workerInformationDto.Email, ModelState);
        //    PassportSeriesValidator.Validate(workerInformationDto.SeriesPassport, ModelState);
        //    PassportNumberValidator.Validate(workerInformationDto.NumberPassport, ModelState);
        //    ExperienceValidator.Validate(workerInformationDto.Experience, ModelState);
        //    DateValidator.Validate(workerInformationDto.DataBirth, ModelState);

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelStateError.Errors(ModelState));
        //    }

        //    _repository.UpdateWorkerInformation(workerInformationDto);
        //    return Ok();
        //}

        //[HttpDelete]
        //[Route("workerInformations")]
        //public IActionResult RemoveWorkerInformation(GetWorkerInformationDto workerInformationDto)
        //{
        //    _repository.RemoveWorkerInformation(workerInformationDto);
        //    return Ok();
        //}
    }
}
