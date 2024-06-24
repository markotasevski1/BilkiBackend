using backend_asp.Models;
using MediatR;
using CategoryModel = backend_asp.Models.Category;
namespace backend_asp.Queries.Category.Requests
{
    public class GetCategoriesQuery : IRequest<List<CategoryModel>>
    {
        public GetCategoriesQuery() { }
    }
}
