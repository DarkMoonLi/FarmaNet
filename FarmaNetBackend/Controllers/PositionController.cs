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
        public IActionResult GetPositions()
        {
            List<PositionDto> positions = _repository.GetPositions().ConvertAll(m => new PositionDto(m));
            return Ok(positions);
        }

        [HttpGet]
        [Route("position")]
        public IActionResult GetPosition(GetPositionDto positionDto)
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
        public IActionResult AddPosition(AddPositionDto positionDto)
        {
            _repository.AddPosition(positionDto);
            return Ok();
        }

        [HttpPost]
        [Route("positions/update")]
        public IActionResult UpdatePosition(UpdatePositionDto positionDto)
        {
            _repository.UpdatePosition(positionDto);
            return Ok();
        }

        [HttpDelete]
        [Route("positions")]
        public IActionResult RemovePosition(GetPositionDto positionDto)
        {
            _repository.RemovePosition(positionDto);
            return Ok();
        }
    }
}
