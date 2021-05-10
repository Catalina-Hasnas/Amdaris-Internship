using Application.DtoModels;
using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface IProductsRepo
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        Task Save();
    }
}
