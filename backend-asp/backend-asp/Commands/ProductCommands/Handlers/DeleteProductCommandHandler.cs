using backend_asp.Abstraction.Common;
using backend_asp.Commands.ProductCommands.Requests;
using backend_asp.Infrastructure.Repository.Interface;
using MediatR;

namespace backend_asp.Commands.ProductCommands.Handlers
{
    public class DeleteProductCommandHandler(IProductRepository productRepository) : IRequestHandler<DeleteProductCommand, Result>
    {
        private readonly IProductRepository productRepository = productRepository;

        public async Task<Result> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            Result result = await productRepository.DeleteProductById(request.ProductId);
            return result;
        }
    }
}
