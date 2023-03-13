using FarmaNetBackend.Dto.PositionDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmaNetBackend.Controllers
{
    public class PositionController : Controller
    {
        private readonly IPositionRepository _repository;

        public PositionController(IPositionRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("positions")]
        public IActionResult GetImports()
        {
            List<PositionDto> positions = _repository.GetPositions().ConvertAll(m => new PositionDto(m));
            return Ok(positions);
        }

        [HttpGet]
        [Route("position")]
        public IActionResult GetImport(GetPositionDto positionDto)
        {
            Position position = _repository.GetPositionById(positionDto);

            if (position == null)
            {
                return NotFound();
            }

            return Ok(position);
        }

        [HttpPost]
        [Route("positions/add")]
        public IActionResult AddImport(AddPositionDto positionDto)
        {
            _repository.AddPosition(positionDto);
            return Ok();
        }

        [HttpPost]
        [Route("positions/update")]
        public IActionResult UpdateImport(UpdatePositionDto positionDto)
        {
            _repository.UpdatePosition(positionDto);
            return Ok();
        }

        [HttpDelete]
        [Route("positions")]
        public IActionResult RemoveImport(GetPositionDto positionDto)
        {
            _repository.RemovePosition(positionDto);
            return Ok();
        }
    }
}
