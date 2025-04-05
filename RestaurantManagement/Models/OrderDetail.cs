using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.Models
{
    public class OrderDetail
    {
        [Key]
        public int Order_Detail_ID { get; set; }

        [ForeignKey("Order")]
        public int Order_ID { get; set; }

        [ForeignKey("MenuItem")]
        public int Item_ID { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public Order Order { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
