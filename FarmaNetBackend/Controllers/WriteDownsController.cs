using FarmaNetBackend.Dto.ManufacturerDto;
using FarmaNetBackend.Dto.WriteDownsDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmaNetBackend.Controllers
{
    public class WriteDownsController : Controller
    {
        private readonly IWriteDownsRepository _repository;

        public WriteDownsController(IWriteDownsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("writeDowns")]
        public IActionResult GetWriteDowns()
        {
            List<WriteDownsDto> writeDowns = _repository.GetWriteDowns().ConvertAll(m => new WriteDownsDto(m));
            return Ok(writeDowns);
        }

        [HttpGet]
        [Route("writeDown")]
        public IActionResult GetWriteDown(GetWriteDownsDto writeDownsDto)
        {
            WriteDowns writeDowns = _repository.GetWriteDownById(writeDownsDto);

            if (writeDowns == null)
            {
                return NotFound();
            }

            return Ok(writeDowns);
        }

        [HttpPost]
        [Route("writeDowns/add")]
        public IActionResult AddWriteDowns(AddWriteDownsDto writeDownsDto)
        {
            _repository.AddWriteDown(writeDownsDto);
            return Ok();
        }

        [HttpPost]
        [Route("writeDowns/update")]
        public IActionResult UpdateWriteDowns(UpdateWriteDownsDto writeDownsDto)
        {
            _repository.UpdateWriteDown(writeDownsDto);
            return Ok();
        }

        [HttpDelete]
        [Route("writeDowns")]
        public IActionResult RemoveWriteDown(GetWriteDownsDto writeDownsDto)
        {
            _repository.RemoveWriteDown(writeDownsDto);
            return Ok();
        }
    }
}
