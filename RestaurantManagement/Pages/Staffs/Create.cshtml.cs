using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantManagement.Data;
using RestaurantManagement.Models;

namespace RestaurantManagement.Pages.Staffs
{
    public class CreateModel : PageModel
    {
        private readonly RestaurantManagement.Data.ApplicationDbContext _context;

        public CreateModel(RestaurantManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Role_ID"] = new SelectList(_context.Role, "Role_ID", "Role_Name");
            return Page();
        }

        [BindProperty]
        public Staff Staff { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Staff.Add(Staff);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
