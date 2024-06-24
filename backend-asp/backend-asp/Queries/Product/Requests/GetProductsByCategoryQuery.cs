using MediatR;
using System.Collections.Generic;
using backend_asp.Models;
using ProductModel = backend_asp.Models.Product;
namespace backend_asp.Queries.Product.Requests
{
    public class GetProductsByCategoryQuery(string category) : IRequest<List<ProductModel>>
    {
        public string Category { get; set; } = category;
    }
}
