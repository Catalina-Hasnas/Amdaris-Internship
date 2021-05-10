using Application;
using Application.DtoModels;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductsRepo: IProductsRepo
    {
        protected readonly ECommerceDbContext _context;
        public ProductsRepo(ECommerceDbContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products
                        .Include( (p) => p.Category )                        
                        .ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products
                        .Include(p => p.Category)
                        .FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}

