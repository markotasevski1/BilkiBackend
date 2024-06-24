using MediatR;
using ProductModel = backend_asp.Models.Product;
namespace backend_asp.Queries.Product.Requests
{
    public class GetProductQuery : IRequest<ProductModel>
    {
        public int Id { get; }

        public GetProductQuery(int id)
        {
            Id = id;
        }
    }
}
