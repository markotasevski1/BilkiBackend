using backend_asp.Abstraction.Common;
using backend_asp.Models;
using MediatR;
using CategoryModel = backend_asp.Models.Category;
namespace backend_asp.Commands.Category.Request
{
    public class CreateNewCategoryCommand(CategoryModel category) : IRequest<Result>
    {
        public CategoryModel Category { get; set; } = category;
    }
}
