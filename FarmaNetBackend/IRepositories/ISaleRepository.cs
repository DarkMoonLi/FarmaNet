using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.SaleDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface ISaleRepository
    {
        public List<Sale> GetSales();
        public List<SaleReportDto> GetSalesByPharmacy(int id);
        public Sale GetSaleById(GetSaleDto saleDto);
        public void AddSale(AddSaleDto saleDto);
        public void UpdateSale(UpdateSaleDto saleDto);
        public void RemoveSale(GetSaleDto saleDto);
    }
}
