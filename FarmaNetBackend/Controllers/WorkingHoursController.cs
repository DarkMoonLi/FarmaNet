using FarmaNetBackend.Dto.WorkingHoursDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Validation;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmaNetBackend.Controllers
{
    public class WorkingHoursController : Controller
    {
        private readonly IWorkinHoursRepository _repository;

        public WorkingHoursController(IWorkinHoursRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("workingHours")]
        public IActionResult GetWorkingHours()
        {
            List<WorkingHoursDto> workingHours = _repository.GetWorkingHours().ConvertAll(m => new WorkingHoursDto(m));
            return Ok(workingHours);
        }

        [HttpGet]
        [Route("workingHoursByWorker/{id}")]
        public IActionResult GetWorkingHoursByWorker(int id)
        {
            List<WorkingHoursDto> workingHours = _repository.GetWorkingHoursByWorker(id).ConvertAll(m => new WorkingHoursDto(m));
            return Ok(workingHours);
        }

        [HttpGet]
        [Route("workingHour")]
        public IActionResult GetWorkingHour(GetWorkingHoursDto workingHoursDto)
        {
            WorkingHours workingHours = _repository.GetWorkingHoursById(workingHoursDto);

            if (workingHours == null)
            {
                return NotFound();
            }

            return Ok(workingHours);
        }

        [HttpPost]
        [Route("workingHours/add")]
        public IActionResult AddWorkingHours(AddWorkingHoursDto workingHoursDto)
        {
            DateValidator.Validate(workingHoursDto.Date, ModelState);
            DescriptionValidator.Validate(workingHoursDto.Description, ModelState);
            TimeValidator.Validate(workingHoursDto.Time, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelStateError.Errors(ModelState));
            }

            _repository.AddWorkingHours(workingHoursDto);
            return Ok();
        }

        [HttpPost]
        [Route("workingHours/update")]
        public IActionResult UpdateWorkingHours(UpdateWorkingHoursDto workingHoursDto)
        {
            DateValidator.Validate(workingHoursDto.Date, ModelState);
            DescriptionValidator.Validate(workingHoursDto.Description, ModelState);
            TimeValidator.Validate(workingHoursDto.Time, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelStateError.Errors(ModelState));
            }

            _repository.UpdateWorkingHours(workingHoursDto);
            return Ok();
        }

        [HttpDelete]
        [Route("workingHours")]
        public IActionResult RemoveWorkingHours(GetWorkingHoursDto workingHoursDto)
        {
            _repository.RemoveWorkingHours(workingHoursDto);
            return Ok();
        }
    }
}
