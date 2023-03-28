using FarmaNetBackend.Dto.ImportDto;
using FarmaNetBackend.Dto.ManufacturerDto;
using FarmaNetBackend.Dto.SupplierDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Validation;
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
        [Route("importByPharmacy/{id}")]
        public IActionResult GetImportsByPharmacy(int id)
        {
            List<ImportReportDto> imports = _repository.GetImportsByPharmacy(id);

            return Ok(imports);
        }

        [HttpGet]
        [Route("suppliersByPharmacy/{id}")]
        public IActionResult GetSuppliersByPharmacy(int id)
        {
            List<SupplierDto> suppliers = _repository.GetSupplierByPharmacy(id);

            return Ok(suppliers);
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
            NumberValidator.Validate(importDto.Number, ModelState);
            SumValidator.Validate(importDto.SumPrice, ModelState);
            DateValidator.Validate(importDto.Date, ModelState);

            if (ModelState.IsValid)
            {
                _repository.AddImport(importDto);
                return Ok();
            }

            return BadRequest( ModelStateError.Errors(ModelState) );
        }

        [HttpPost]
        [Route("imports/update")]
        public IActionResult UpdateImport(UpdateImportDto importDto)
        {
            NumberValidator.Validate(importDto.Number, ModelState);
            SumValidator.Validate(importDto.SumPrice, ModelState);
            DateValidator.Validate(importDto.Date, ModelState);

            if (ModelState.IsValid)
            {
                _repository.UpdateImport(importDto);
                return Ok();
            }

            return BadRequest( ModelStateError.Errors(ModelState) );
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
