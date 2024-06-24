using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using backend_asp.Models;
using backend_asp.Queries.Product.Requests;
using ProductModel = backend_asp.Models.Product;
using backend_asp.Infrastructure.Repository.Interface;

namespace backend_asp.Queries.Product.Handlers
{
    public class GetProductsByCategoryQueryHandler : IRequestHandler<GetProductsByCategoryQuery, List<ProductModel>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductsByCategoryQueryHandler(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public async Task<List<ProductModel>> Handle(GetProductsByCategoryQuery request, CancellationToken cancellationToken)
        {
            List<ProductModel> products = await _productRepository.GetProductsByCategoryAsync(request.Category);

            return products;
        }
    }
}
