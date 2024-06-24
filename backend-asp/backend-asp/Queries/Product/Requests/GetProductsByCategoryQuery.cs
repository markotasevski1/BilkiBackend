using MediatR;
using System.Collections.Generic;
using backend_asp.Models;

namespace backend_asp.Queries.Product.Requests
{
    public class GetProductsByCategoryQuery : IRequest<List<backend_asp.Models.Product>>
    {
        public int Category { get; set; }

        public GetProductsByCategoryQuery(int category)
        {
            Category = category;
        }
    }
}
