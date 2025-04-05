using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagement.Models
{
    public class Staff
    {
        [Key]
        public int Staff_ID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Fullname { get; set; }

        public string Phone { get; set; }

        [ForeignKey("Role")]
        public int Role_ID { get; set; }

        public DateTime Created_At { get; set; } = DateTime.Now;

        public Role Role { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
