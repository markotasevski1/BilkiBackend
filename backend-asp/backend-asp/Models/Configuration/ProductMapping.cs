using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend_asp.Models.Configuration
{
    public class ProductMapping(string schema) : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product", schema);

            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedOn).HasColumnName("CreatedOn").HasColumnType("datetime2(0)").IsRequired();

            builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasColumnName("Description").HasColumnType("nvarchar").HasMaxLength(500).IsRequired();
            builder.Property(x => x.Price).HasColumnName("Price").HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(x => x.Quantity).HasColumnName("Quantity").HasColumnType("int").IsRequired();

            builder.HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.CategoryFk);
        }
    }
}
