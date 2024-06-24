using backend_asp.Abstraction;
using MediatR;
using ProductModel = backend_asp.Models.Product;
namespace backend_asp.Queries.Product.Requests
{
    public class GetProductsQuery : IRequest<List<ProductModel>>
    {
        public GetProductsQuery() { }
    }
}
