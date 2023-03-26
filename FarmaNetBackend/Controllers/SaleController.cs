using FarmaNetBackend.Dto.SaleDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using FarmaNetBackend.Validation;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FarmaNetBackend.Controllers
{
    public class SaleController : Controller
    {
        private readonly ISaleRepository _repository;

        public SaleController(ISaleRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("sales")]
        public IActionResult GetSales()
        {
            List<SaleDto> sales = _repository.GetSales().ConvertAll(m => new SaleDto(m));
            return Ok(sales);
        }

        [HttpGet]
        [Route("sale")]
        public IActionResult GetSale(GetSaleDto saleDto)
        {
            Sale sale = _repository.GetSaleById(saleDto);

            if (sale == null)
            {
                return NotFound();
            }

            return Ok(sale);
        }

        [HttpPost]
        [Route("sales/add")]
        public IActionResult AddSale(AddSaleDto saleDto)
        {
            QuantityValidator.Validate(saleDto.Quantity, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelStateError.Errors(ModelState));
            }

            _repository.AddSale(saleDto);
            return Ok();
        }

        [HttpPost]
        [Route("sales/update")]
        public IActionResult UpdateSale(UpdateSaleDto saleDto)
        {
            QuantityValidator.Validate(saleDto.Quantity, ModelState);
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelStateError.Errors(ModelState));
            }

            _repository.UpdateSale(saleDto);
            return Ok();
        }

        [HttpDelete]
        [Route("sales")]
        public IActionResult RemoveSale(GetSaleDto saleDto)
        {
            _repository.RemoveSale(saleDto);
            return Ok();
        }
    }
}
