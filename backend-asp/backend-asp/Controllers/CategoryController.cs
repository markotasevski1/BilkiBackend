using backend_asp.Models;
using backend_asp.Queries.Product.Requests;
using MediatR;
using backend_asp.Queries.Category.Requests;
using Microsoft.AspNetCore.Mvc;
using backend_asp.Abstraction.Common;
using backend_asp.Commands.Category.Request;

namespace backend_asp.Controllers
{
    [ApiController]
    [Route("category")]
    public class CategoryController : ControllerBase
    {

        private readonly ILogger<ProductsController> _logger;
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator, ILogger<ProductsController> logger)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Category>> GetAllCategories()
        {
            var result = await _mediator.Send(new GetCategoriesQuery());

            return result;
        }

        [HttpPost]
        public async Task<Result> GetAllCategories(Category category)
        {
            var result = await _mediator.Send(new CreateNewCategoryCommand(category));

            return result;
        }
    }
}
