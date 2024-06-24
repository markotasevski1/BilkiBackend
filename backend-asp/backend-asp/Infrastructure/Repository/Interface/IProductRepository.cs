using System.Collections.Generic;
using System.Threading.Tasks;
using backend_asp.Models;

namespace backend_asp.Infrastructure.Repository.Interface
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> GetAllAsync();
    }
}
