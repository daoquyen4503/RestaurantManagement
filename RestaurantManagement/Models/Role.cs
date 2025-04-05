using System.ComponentModel.DataAnnotations;

namespace RestaurantManagement.Models
{
    public class Role
    {
        [Key]
        public int Role_ID { get; set; }

        [Required]
        public string Role_Name { get; set; }

        public string Description { get; set; }
        public ICollection<Staff> Staffs { get; set; }
    }
}
