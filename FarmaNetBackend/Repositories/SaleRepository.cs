using FarmaNetBackend.Dto.SaleDto;
using FarmaNetBackend.Infrastructure;
using FarmaNetBackend.IRepositories;
using FarmaNetBackend.Models;
using System.Collections.Generic;
using System.Linq;

namespace FarmaNetBackend.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        ApplicationDbContext _context;

        public SaleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Sale> GetSales()
        {
            return _context.Sales.ToList();
        }

        public Sale GetSaleById(GetSaleDto saleDto)
        {
            return _context.Sales.FirstOrDefault(s => s.PharmacyId == saleDto.PharmacyId && s.MedicationId == saleDto.MedicationId);
        }

        public void AddSale(AddSaleDto saleDto)
        {
            Sale sale = saleDto.ConvertToSale();

            _context.Sales.Add(sale);
            _context.SaveChanges();
        }

        public void UpdateSale(UpdateSaleDto saleDto)
        {
            Sale sale = GetSaleById(new GetSaleDto { PharmacyId = saleDto.PharmacyId, MedicationId = saleDto.MedicationId });

            if (sale != null)
            {
                sale.Price = saleDto.Price;
                sale.Quantity = saleDto.Quantity;

                _context.Sales.Update(sale);
                _context.SaveChanges();
            }
        }

        public void RemoveSale(GetSaleDto saleDto)
        {
            Sale sale = GetSaleById(saleDto);

            if (sale != null)
            {
                _context.Sales.Remove(sale);
                _context.SaveChanges();
            }
        }
    }
}
