using domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAcces
{
    public class SeedDb
    {
        private readonly DataContext _context;
        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckProductAsync();
            await CheckSaleAsync();
        }

        private async Task CheckProductAsync()
        {
            if (_context.Products.Any())
            {
                _context.Products.Add(
                    new ProductEntity { Name = "Televisor", Price = "35000", Stock = "34" }
                    );
                _context.Products.Add(
                    new ProductEntity { Name = "Telefono", Price = "35000", Stock = "34" }
                    );
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckSaleAsync()
        {
            if (_context.Bills.Any())
            {
                DateTime startDate = DateTime.Today.ToUniversalTime();

                _context.Bills.Add(
                    new BillEntity
                    {
                        Date = startDate,
                        FullSale = 70000,
                        BillDetails = new List<BillDetailEntity>
                        {
                            new BillDetailEntity { QuantityOrdered = 2, Product = _context.Products.FirstOrDefault(t => t.Name == "Televisor") }
                        }
                    }
                    );
                _context.Bills.Add(
                    new BillEntity
                    {
                        Date = startDate,
                        FullSale = 70000,
                        BillDetails = new List<BillDetailEntity>
                        {
                            new BillDetailEntity { QuantityOrdered = 1, Product = _context.Products.FirstOrDefault(t => t.Name == "Televisor") },
                            new BillDetailEntity { QuantityOrdered = 1, Product = _context.Products.FirstOrDefault(t => t.Name == "Televisor") }
                        }
                    }
                    );
                await _context.SaveChangesAsync();
            }
        }
    }
}
