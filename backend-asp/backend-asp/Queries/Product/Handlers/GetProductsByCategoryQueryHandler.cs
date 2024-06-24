using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using backend_asp.Models;
using backend_asp.Queries.Product.Requests;
using ProductModel = backend_asp.Models.Product;

namespace backend_asp.Queries.Product.Handlers
{
    public class GetProductsByCategoryQueryHandler : IRequestHandler<GetProductsByCategoryQuery, List<ProductModel>>
    {
        public Task<List<ProductModel>> Handle(GetProductsByCategoryQuery request, CancellationToken cancellationToken)
        {
            List<ProductModel> products = new();
            var random = new Random();

            for (int i = 0; i < 5; i++) // generate 5 random products
            {
                products.Add(new ProductModel(
                    $"Product {i + 1} in {request.Category}",
                    $"Description for product {i + 1} in {request.Category}",
                    random.NextDouble() * 100, // Random price
                    random.Next(1, 100), // Random quantity
                    request.Category // Assuming CategoryFk is an int and request.Category provides a valid category ID
                )
                {
                    Id = random.Next(1, 1000),
                    Name = i.ToString(),
                });
            }

            // Wrap the result in a Task
            return Task.FromResult(products);
        }
    }
}
