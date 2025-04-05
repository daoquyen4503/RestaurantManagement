using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Data;
using RestaurantManagement.Models;

namespace RestaurantManagement.Pages.MenuItems
{
    public class DetailsModel : PageModel
    {
        private readonly RestaurantManagement.Data.ApplicationDbContext _context;

        public DetailsModel(RestaurantManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public MenuItem MenuItem { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuitem = await _context.MenuItem.FirstOrDefaultAsync(m => m.Item_ID == id);
            if (menuitem == null)
            {
                return NotFound();
            }
            else
            {
                MenuItem = menuitem;
            }
            return Page();
        }
    }
}
