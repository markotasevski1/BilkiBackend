using backend_asp.Models;
using backend_asp.Models.Configuration;
using backend_asp.Models.Identity;
using Microsoft.EntityFrameworkCore;

namespace backend_asp.Infrastructure.Persistance
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<BaseUser> Users { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            const string EcommerceSchema = "ShopDb";

            modelBuilder.ApplyConfiguration(new ProductMapping(EcommerceSchema));
            modelBuilder.ApplyConfiguration(new CategoryMapping(EcommerceSchema));
            //modelBuilder.ApplyConfiguration(new ShoppingCartMapping(EcommerceSchema));
            //modelBuilder.ApplyConfiguration(new OrderMapping(EcommerceSchema));
            //modelBuilder.ApplyConfiguration(new UserMapping(EcommerceSchema));
        }
    }
}
