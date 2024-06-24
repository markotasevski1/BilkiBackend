using backend_asp.Models.Base;

namespace backend_asp.Models
{
    public class Category(string Name, string Description) : BaseEntity
    {
        public string Name { get; set; } = Name;
        public string Description { get; set; } = Description;

    }
}
