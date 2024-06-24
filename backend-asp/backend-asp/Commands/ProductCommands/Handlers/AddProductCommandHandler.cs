using backend_asp.Abstraction;
using backend_asp.Abstraction.Common;
using backend_asp.Commands.ProductCommands.Requests;
using backend_asp.Infrastructure.Repository.Implementation;
using backend_asp.Infrastructure.Repository.Interface;
using MediatR;

namespace backend_asp.Commands.ProductCommands.Handlers
{
    public class AddProductCommandHandler(IProductRepository productRepository) : IRequestHandler<AddProductCommand, Result>
    {
        private readonly IProductRepository _productRepository = productRepository;

        public Task<Result> Handle(AddProductCommand command, CancellationToken cancellationToken)
        {
            return _productRepository.CreateProduct(command.Product);
        }
    }
}
