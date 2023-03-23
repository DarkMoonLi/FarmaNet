﻿using FarmaNetBackend.Dto.SupplierDto;
using FarmaNetBackend.Dto.SupplierDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult AddSupplier(AddSupplierDto supplierDto)
        {
            _repository.AddSupplier(supplierDto);
            return Ok();
        }

        [HttpPost]
        [Route("suppliers/update")]
        public IActionResult UpdateSupplier(UpdateSupplierDto supplierDto)
        {
            _repository.UpdateSupplier(supplierDto);
            return Ok();
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
