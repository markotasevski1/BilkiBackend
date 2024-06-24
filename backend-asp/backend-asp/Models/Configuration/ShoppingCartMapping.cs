using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend_asp.Models.Configuration
{
    public class ShoppingCartMapping(string schema) : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            throw new NotImplementedException();
        }
    }
}
