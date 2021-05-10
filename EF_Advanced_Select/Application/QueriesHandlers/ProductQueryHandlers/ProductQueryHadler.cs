using Application.DtoModels;
using Application.Queries.ProductQueries;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Application.QueriesHandlers.ProductQueryHandlers
{
    public class ProductQueryHadler : IRequestHandler<GetAllProductsQuery, IEnumerable<ProductDto>>, IRequestHandler<GetProductByIdQuery, ProductDto>
    {
        private readonly IProductsRepo _productRepository;

        public ProductQueryHadler(IProductsRepo productRepository) 
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var result = await _productRepository.GetAllProducts();
            
            return result.Select(p => new ProductDto
                         {
                            Id = p.Id,
                            Amount = p.Amount,
                            Image = p.Image,
                            Price = p.Price,
                            Title = p.Title,
                            CreatedAt = p.CreatedAt,
                            Category = new CategoryDto 
                            {
                                Id = p.Category.Id,
                                Name = p.Category.Name
                            }
                         }).ToList();
        }

        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _productRepository.GetProductById(request.Id);
            return new ProductDto {
                Id = result.Id,
                Amount = result.Amount,
                Image = result.Image,
                Price = result.Price,
                Title = result.Title,
                CreatedAt = result.CreatedAt,
                Category = new CategoryDto
                {
                    Id = result.Category.Id,
                    Name = result.Category.Name
                }
            };
        }
    }
}
