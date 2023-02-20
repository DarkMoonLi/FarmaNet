using FarmaNetBackend.Domain.Models;
using FarmaNetBackend.Dto.SaleDto;
using System.Collections.Generic;

namespace FarmaNetBackend.Domain.IRepositories
{
    public interface ISaleRepository
    {
        public List<Sale> GetSales();
        public Sale GetSaleById(int id);
        public void AddSale(SaleDto saleDto);
        public void UpdateSale(SaleDto saleDto);
        public void RemoveSale(int id);
    }
}
