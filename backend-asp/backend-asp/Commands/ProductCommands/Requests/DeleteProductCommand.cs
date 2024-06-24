using backend_asp.Abstraction.Common;
using MediatR;

namespace backend_asp.Commands.ProductCommands.Requests
{
    public class DeleteProductCommand(int id) : IRequest<Result>
    {
        public int ProductId { get; set; } = id;
    }
}
