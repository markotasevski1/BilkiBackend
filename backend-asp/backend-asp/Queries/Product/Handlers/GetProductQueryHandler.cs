using backend_asp.Infrastructure.Repository.Interface;
using backend_asp.Queries.Product.Requests;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ProductModel = backend_asp.Models.Product;
namespace backend_asp.Queries.Product.Handlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductModel>
    {
        private readonly IProductRepository productRepository;
        public async Task<ProductModel> Handle(GetProductQuery query, CancellationToken cancellationToken)
        {
            ProductModel productModel = await productRepository.GetByIdAsync(query.Id);
            return productModel;
        }


    }
}
