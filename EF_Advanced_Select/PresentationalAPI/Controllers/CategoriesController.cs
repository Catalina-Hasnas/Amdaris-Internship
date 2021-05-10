using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
using MediatR;
using Application.Queries.CategoriesQueries;

namespace PresentationalAPI.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            var input = new GetAllCategoriesQuery();
            var productItems = await _mediator.Send(input);
            return Ok(productItems);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategoryById(int id)
        {
            var input = new GetCategoryByIdQuery
            {
                Id = id
            };
            var productItem = await _mediator.Send(input);
            return Ok(productItem);
        }
    }
}
