using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace RestaurantManagement.Data
{
    public static class IdentitySeedData
    {
        private static readonly string[] Roles = new[] { "Customer", "Staff", "Manager", "Waiter", "Chef", "Cashier" };

        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            // Tạo các vai trò nếu chưa có
            foreach (var role in Roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            // Tạo tài khoản admin mẫu
            string adminEmail = "admin@restaurant.com";
            string adminPassword = "Admin123!";

            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new IdentityUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(adminUser, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Manager"); // gán vai trò Manager
                }
            }
        }
    }
}
