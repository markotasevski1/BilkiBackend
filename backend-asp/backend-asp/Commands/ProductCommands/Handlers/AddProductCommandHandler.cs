using backend_asp.Abstraction;
using backend_asp.Abstraction.Common;
using backend_asp.Commands.ProductCommands.Requests;
using MediatR;

namespace backend_asp.Commands.ProductCommands.Handlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Result>
    {

        public Task<Result> Handle(AddProductCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
