using System.Collections.Generic;
using System.Threading.Tasks;
using backend_asp.Abstraction.Common;
using backend_asp.Models;

namespace backend_asp.Infrastructure.Repository.Interface
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);

        Task<Result> CreateProduct(Product product);

        Task<Result> DeleteProductById(int id);

        Task<List<Product>> GetAllAsync();

        Task<List<Product>> GetProductsByCategoryAsync(string categoryName);
    }
}
