using backend_asp.Abstraction.Common;
using backend_asp.Models;

namespace backend_asp.Infrastructure.Repository.Interface
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync();

        Task<Result> CreateCategory(Category newCategory);
    }
}
