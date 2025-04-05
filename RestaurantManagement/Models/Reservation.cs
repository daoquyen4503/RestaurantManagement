using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.Models
{
    public class Reservation
    {
        [Key]
        public int Reservation_ID { get; set; }

        [ForeignKey("Customer")]
        public int Customer_ID { get; set; }

        [ForeignKey("Table")]
        public int Table_ID { get; set; }

        public DateTime Reservation_DateTime { get; set; }

        public int Number_of_People { get; set; }

        public string Status { get; set; } // Enum: 'Booked', 'Cancelled', 'Completed'

        public string Note { get; set; }

        public Customer Customer { get; set; }
        public Table Table { get; set; }
    }
}
