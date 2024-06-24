using backend_asp.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend_asp.Models.Configuration
{
    public class UserMapping(string schema) : IEntityTypeConfiguration<BaseUser>
    {
        public void Configure(EntityTypeBuilder<BaseUser> builder)
        {
            throw new NotImplementedException();
        }
    }
}
