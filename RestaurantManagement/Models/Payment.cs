using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.Models
{
    public class Payment
    {
        [Key]
        public int Payment_ID { get; set; }

        [ForeignKey("Order")]
        public int Order_ID { get; set; }

        public DateTime Payment_Date { get; set; }

        public string Payment_Method { get; set; } // Enum: 'Cash', 'Card', 'E-wallet'

        public string Status { get; set; }

        public int? Cashier_ID { get; set; }

        public Order Order { get; set; }
    }
}
