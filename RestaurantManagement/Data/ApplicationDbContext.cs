using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace RestaurantManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<RestaurantManagement.Models.Category> Category { get; set; } = default!;
        public DbSet<RestaurantManagement.Models.Customer> Customer { get; set; } = default!;
        public DbSet<RestaurantManagement.Models.MenuItem> MenuItem { get; set; } = default!;
        public DbSet<RestaurantManagement.Models.Order> Order { get; set; } = default!;
        public DbSet<RestaurantManagement.Models.OrderDetail> OrderDetail { get; set; } = default!;
        public DbSet<RestaurantManagement.Models.Payment> Payment { get; set; } = default!;
        public DbSet<RestaurantManagement.Models.Reservation> Reservation { get; set; } = default!;
        public DbSet<RestaurantManagement.Models.Role> Role { get; set; } = default!;
        public DbSet<RestaurantManagement.Models.Staff> Staff { get; set; } = default!;
        public DbSet<RestaurantManagement.Models.Table> Table { get; set; } = default!;
    }
}
