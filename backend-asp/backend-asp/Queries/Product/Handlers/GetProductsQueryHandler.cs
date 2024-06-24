using backend_asp.Abstraction;
using backend_asp.Abstraction.Common;
using backend_asp.Infrastructure.Repository.Implementation;
using backend_asp.Infrastructure.Repository.Interface;
using backend_asp.Queries.Product.Requests;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ProductModel = backend_asp.Models.Product;

namespace backend_asp.Queries.Product.Handlers
{
    public class GetProductsQueryHandler(IProductRepository productRepository) : IRequestHandler<GetProductsQuery, List<ProductModel>>
    {
        private readonly IProductRepository _productRepository = productRepository;

        public async Task<List<ProductModel>> Handle(GetProductsQuery query, CancellationToken cancellationToken)
        {
            List<ProductModel> products = await _productRepository.GetAllAsync();
            return products;
        }
    }
}
