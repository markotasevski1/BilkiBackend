using backend_asp.Abstraction.Common;
using MediatR;
using System.Windows.Input;
using ICommand = backend_asp.Abstraction.ICommand;
using Product = backend_asp.Models.Product;
namespace backend_asp.Commands.ProductCommands.Requests
{
    public sealed record AddProductCommand : IRequest<Result>
    {
        public Product addProduct { get; set; }

        public AddProductCommand(Product product)
        {
            addProduct = product;
        }
    }
}
