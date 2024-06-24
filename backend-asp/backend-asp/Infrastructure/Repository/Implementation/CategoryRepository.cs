using backend_asp.Abstraction.Common;
using backend_asp.Infrastructure.Persistance;
using backend_asp.Infrastructure.Repository.Interface;
using backend_asp.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_asp.Infrastructure.Repository.Implementation
{
    public class CategoryRepository(ApplicationDbContext context) : ICategoryRepository
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<Result> CreateCategory(Category newCategory)
        {
            var test = await _context.Categories.AddAsync(newCategory);

            if (test != null)
            {
                await _context.SaveChangesAsync();
            }
            return Result.Success();
        }

        public Task<List<Category>> GetAllAsync()
        {
            return _context.Categories.ToListAsync();
        }
    }
}
