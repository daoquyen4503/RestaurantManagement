using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Data;
using RestaurantManagement.Models;

namespace RestaurantManagement.Pages.Roles
{
    public class IndexModel : PageModel
    {
        private readonly RestaurantManagement.Data.ApplicationDbContext _context;

        public IndexModel(RestaurantManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Role> Role { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Role = await _context.Role.ToListAsync();
        }
    }
}
