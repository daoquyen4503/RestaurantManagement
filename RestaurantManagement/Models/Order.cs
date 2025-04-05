using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.Models
{
    public class Order
    {
        [Key]
        public int Order_ID { get; set; }

        [ForeignKey("Table")]
        public int Table_ID { get; set; }

        [ForeignKey("Staff")]
        public int Staff_ID { get; set; }

        public DateTime Order_Date { get; set; }

        public string Status { get; set; } // Enum: 'New', 'Preparing', 'Served', 'Paid'

        public decimal Total_Amount { get; set; }

        public Table Table { get; set; }
        public Staff Staff { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } // Assuming OrderItem is another model representing items in the order
        public ICollection<Payment> Payments { get; set; } // Assuming Payment is another model representing payments for the order

    }
}
