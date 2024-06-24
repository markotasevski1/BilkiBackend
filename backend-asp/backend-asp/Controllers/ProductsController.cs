using backend_asp.Abstraction.Common;
using backend_asp.Commands.ProductCommands.Requests;
using backend_asp.Models;
using backend_asp.Queries.Product.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductModel = backend_asp.Models.Product;

namespace backend_asp.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator, ILogger<ProductsController> logger)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<ProductModel>> GetProducts()
        {
            var result = await _mediator.Send(new GetProductsQuery());

            return result;
        }

        [HttpGet("{id:int}")]
        public async Task<ProductModel> GetProductById(int id)
        {
            var product = await _mediator.Send(new GetProductQuery(id));


            return product;
        }

        [HttpGet("category/{category}")]
        public async Task<List<Product>> GetProductsByCategory( string category)
        {
            var products = await _mediator.Send(new GetProductsByCategoryQuery(category));
            return (List<Product>)products;
        }


        [HttpPost]
        public async Task<ActionResult<Result>> AddProduct(Product product)
        {
            Result result = await _mediator.Send(new AddProductCommand(product));
            return result;
        }

        [HttpDelete]
        public async Task<ActionResult<Result>> DeleteProduct(int id)
        {
            Result result = await _mediator.Send(new DeleteProductCommand(id));
            return result;
        }

    }
}
