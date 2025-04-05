using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.Models
{
    public class MenuItem
    {
        [Key]
        public int Item_ID { get; set; }

        [ForeignKey("Category")]
        public int Category_ID { get; set; }

        [Required]
        public string Item_Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Status { get; set; } // Enum: 'Serving', 'Out of stock'

        public Category Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
