using Microsoft.AspNetCore.Identity;

namespace backend_asp.Models.Identity
{
    public class BaseUser : IdentityUser
    {
        public string? Initials { get; set; }
    }
}
