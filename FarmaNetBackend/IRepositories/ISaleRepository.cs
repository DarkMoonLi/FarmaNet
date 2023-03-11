﻿using FarmaNetBackend.Models;
using FarmaNetBackend.Dto.SaleDto;
using System.Collections.Generic;

namespace FarmaNetBackend.IRepositories
{
    public interface ISaleRepository
    {
        public List<Sale> GetSales();
        public Sale GetSaleById(int id);
        public void AddSale(AddSaleDto saleDto);
        public void UpdateSale(UpdateSaleDto saleDto);
        public void RemoveSale(int id);
    }
}