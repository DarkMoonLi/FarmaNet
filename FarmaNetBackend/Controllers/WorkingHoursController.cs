using FarmaNetBackend.Dto.ImportDto;
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
            DescriptionValidator.Validate(workingHoursDto.Description, ModelState);

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
            DescriptionValidator.Validate(workingHoursDto.Description, ModelState);

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
