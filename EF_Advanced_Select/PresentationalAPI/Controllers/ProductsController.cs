using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
using MediatR;
using Application.Queries.ProductQueries;
using Application.DtoModels;

namespace PresentationalAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts()
        {
            var input = new GetAllProductsQuery();
            var productItems = await _mediator.Send(input);
            return Ok(productItems);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var input = new GetProductByIdQuery
            {
                Id = id
            };
            var productItem = await _mediator.Send(input);
            return Ok(productItem);
        }
    }
}
