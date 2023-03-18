using FarmaNetBackend.Dto.ImportDto;
using FarmaNetBackend.Dto.ManufacturerDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmaNetBackend.Controllers
{
    public class ImportController : Controller
    {
        private readonly IImportRepository _repository;

        public ImportController(IImportRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("imports")]
        public IActionResult GetImports()
        {
            List<ImportDto> imports = _repository.GetImports().ConvertAll(m => new ImportDto(m));
            return Ok(imports);
        }

        [HttpGet]
        [Route("import")]
        public IActionResult GetImport(GetImportDto importDto)
        {
            Import import = _repository.GetImportById(importDto);

            if (import == null)
            {
                return NotFound();
            }

            return Ok(import);
        }

        [HttpPost]
        [Route("imports/add")]
        public IActionResult AddImport(AddImportDto importDto)
        {
            _repository.AddImport(importDto);
            return Ok();
        }

        [HttpPost]
        [Route("imports/update")]
        public IActionResult UpdateImport(UpdateImportDto importDto)
        {
            _repository.UpdateImport(importDto);
            return Ok();
        }

        [HttpDelete]
        [Route("imports")]
        public IActionResult RemoveImport(GetImportDto importDto)
        {
            _repository.RemoveImport(importDto);
            return Ok();
        }
    }
}
