using System.ComponentModel.DataAnnotations;

namespace backend_asp.Models.Base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
