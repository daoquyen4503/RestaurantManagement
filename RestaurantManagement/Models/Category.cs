using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class Category
    {
        [Key]
        public int Category_ID { get; set; }

        [Required]
        public string Category_Name { get; set; }

        public string Description { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
