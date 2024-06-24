using backend_asp.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend_asp.Models.Configuration
{
    public class UserMapping : IEntityTypeConfiguration<BaseUser>
    {
        private readonly string _schema;

        public UserMapping(string schema)
        {
            _schema = schema;
        }

        public void Configure(EntityTypeBuilder<BaseUser> builder)
        {
            builder.ToTable("Users", _schema);

            // Additional configuration for BaseUser properties
            builder.Property(u => u.Initials)
                .HasMaxLength(5)
                .IsRequired(false);
        }
    }
}
