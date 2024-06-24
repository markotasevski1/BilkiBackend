using backend_asp.Models.Base;

namespace backend_asp.Models
{
    public class Product(string Name, string Description, double Price, int Quantity, int CategoryFk) : BaseEntity
    {
        public string Name { get; set; } = Name;

        public string Description { get; set; } = Description;

        public double Price { get; set; } = Price;

        public int Quantity { get; set; } = Quantity;

        public int CategoryFk { get; set; } = CategoryFk;

         public virtual Category Category { get; set; } 

        // add thumbnail image

        // add list of images?

    }
}
