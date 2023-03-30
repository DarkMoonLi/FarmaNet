using FarmaNetBackend.Dto.SupplierDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Validation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FarmaNetBackend.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierRepository _repository;

        public SupplierController(ISupplierRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("suppliers")]
        public IActionResult GetSuppliers()
        {
            List<SupplierDto> suppliers = _repository.GetSuppliers().ConvertAll(m => new SupplierDto(m));
            return Ok(suppliers);
        }

        [HttpGet]
        [Route("supplier")]
        public IActionResult GetSupplier(GetSupplierDto supplierDto)
        {
            Supplier supplier = _repository.GetSupplierById(supplierDto);

            if (supplier == null)
            {
                return NotFound();
            }

            return Ok(supplier);
        }

        [HttpPost]
        [Route("suppliers/add")]
        public IActionResult AddSupplier(AddSupplierDto supplierDto, IFormFile image)
        {
            NameValidator.Validate(supplierDto.Name, ModelState);
            InnValidator.Validate(supplierDto.Inn, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelStateError.Errors(ModelState));
            }

            try
            {
                _repository.AddSupplier(supplierDto);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("suppliers/update")]
        public IActionResult UpdateSupplier(UpdateSupplierDto supplierDto)
        {
            NameValidator.Validate(supplierDto.Name, ModelState);
            InnValidator.Validate(supplierDto.Inn, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelStateError.Errors(ModelState));
            }

            try
            {
                _repository.UpdateSupplier(supplierDto);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("suppliers")]
        public IActionResult RemoveSupplier(GetSupplierDto supplierDto)
        {
            _repository.RemoveSupplier(supplierDto);
            return Ok();
        }
    }
}
