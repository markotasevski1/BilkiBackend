using backend_asp.Abstraction.Common;
using backend_asp.Commands.Category.Request;
using backend_asp.Infrastructure.Repository.Implementation;
using backend_asp.Infrastructure.Repository.Interface;
using MediatR;

namespace backend_asp.Commands.Category.Handler
{
    public class CreateNewCategoryCommandHandler(ICategoryRepository categoryRepository) : IRequestHandler<CreateNewCategoryCommand, Result>
    {
        private readonly ICategoryRepository _categoryRepository = categoryRepository;

        public Task<Result> Handle(CreateNewCategoryCommand request, CancellationToken cancellationToken)
        {
            return _categoryRepository.CreateCategory(request.Category);
        }
    }
}
