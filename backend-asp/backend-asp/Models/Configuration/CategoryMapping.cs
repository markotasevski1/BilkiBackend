using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend_asp.Models.Configuration
{
    public class CategoryMapping(string schema) : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category", schema);

            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedOn).HasColumnName("CreatedOn").HasColumnType("datetime2(0)").IsRequired();

            builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasColumnName("Description").HasColumnType("nvarchar").HasMaxLength(500).IsRequired();
        }
    }
}
