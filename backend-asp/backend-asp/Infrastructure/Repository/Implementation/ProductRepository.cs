using backend_asp.Infrastructure.Persistance;
using backend_asp.Infrastructure.Repository.Interface;
using backend_asp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend_asp.Abstraction.Common;

namespace backend_asp.Infrastructure.Repository.Implementation
{
    public class ProductRepository(ApplicationDbContext context) : IProductRepository
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Result> CreateProduct(Product product)
        {
            var test = await _context.Products.AddAsync(product);

            if(test != null)
            {
                await _context.SaveChangesAsync();
            }
            return Result.Success();
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(string categoryName)
        {
            return await _context.Products.Where(x=>x.Category.Name == categoryName).ToListAsync();
        }

        public async Task<Result> DeleteProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return Result.Failure(new Error("ProductNotFound", "Product not found."));
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return Result.Success();
        }
    }
}
