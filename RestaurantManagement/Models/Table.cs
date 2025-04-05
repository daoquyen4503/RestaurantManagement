using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class Table
    {
        [Key]
        public int Table_ID { get; set; }

        public string Table_Number { get; set; }

        public int Capacity { get; set; }

        public string Status { get; set; } // Enum: 'Empty', 'In service', 'Cleaning'
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
