using FarmaNetBackend.Dto.WorkerInformationDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
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
        [Route("workerInformation")]
        public IActionResult GetWorkerInformation(GetWorkerInformationDto workerInformationDto)
        {
            WorkerInformation workerInformation = _repository.GetWorkerInformationById(workerInformationDto);

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
            _repository.AddWorkerInformation(workerInformationDto);
            return Ok();
        }

        [HttpPost]
        [Route("workerInformations/update")]
        public IActionResult UpdateWorkerInformation(UpdateWorkerInformationDto workerInformationDto)
        {
            _repository.UpdateWorkerInformation(workerInformationDto);
            return Ok();
        }

        [HttpDelete]
        [Route("workerInformations")]
        public IActionResult RemoveWorkerInformation(GetWorkerInformationDto workerInformationDto)
        {
            _repository.RemoveWorkerInformation(workerInformationDto);
            return Ok();
        }
    }
}
