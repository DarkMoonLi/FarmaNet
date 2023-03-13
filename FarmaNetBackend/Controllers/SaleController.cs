using FarmaNetBackend.Dto.SaleDto;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
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
        public IActionResult GetImports()
        {
            List<SaleDto> sales = _repository.GetSales().ConvertAll(m => new SaleDto(m));
            return Ok(sales);
        }

        [HttpGet]
        [Route("sale")]
        public IActionResult GetImport(GetSaleDto saleDto)
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
        public IActionResult AddImport(AddSaleDto saleDto)
        {
            _repository.AddSale(saleDto);
            return Ok();
        }

        [HttpPost]
        [Route("sales/update")]
        public IActionResult UpdateImport(UpdateSaleDto saleDto)
        {
            _repository.UpdateSale(saleDto);
            return Ok();
        }

        [HttpDelete]
        [Route("sales")]
        public IActionResult RemoveImport(GetSaleDto saleDto)
        {
            _repository.RemoveSale(saleDto);
            return Ok();
        }
    }
}
