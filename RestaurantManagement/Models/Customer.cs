using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class Customer
    {
        [Key]
        public int Customer_ID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Fullname { get; set; }

        public string Phone { get; set; }

        public DateTime Created_At { get; set; } = DateTime.Now;
        public ICollection<Reservation> Reservations { get; set; }
    }
}
