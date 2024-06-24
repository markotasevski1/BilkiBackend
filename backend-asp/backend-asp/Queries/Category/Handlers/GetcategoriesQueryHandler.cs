using backend_asp.Infrastructure.Repository.Interface;
using backend_asp.Queries.Category.Requests;
using backend_asp.Queries.Product.Requests;
using MediatR;
using CategoryModel = backend_asp.Models.Category;

namespace backend_asp.Queries.Category.Handlers
{
    public class GetcategoriesQueryHandler(ICategoryRepository categoryRepository) : IRequestHandler<GetCategoriesQuery, List<CategoryModel>>
    {
        private readonly ICategoryRepository _categoryRepository = categoryRepository;

        public async Task<List<CategoryModel>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await _categoryRepository.GetAllAsync();
        }
    }
}
