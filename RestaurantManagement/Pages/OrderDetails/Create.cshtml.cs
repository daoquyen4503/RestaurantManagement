using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantManagement.Data;
using RestaurantManagement.Models;

namespace RestaurantManagement.Pages.OrderDetails
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
        ViewData["Item_ID"] = new SelectList(_context.MenuItem, "Item_ID", "Item_Name");
        ViewData["Order_ID"] = new SelectList(_context.Order, "Order_ID", "Order_ID");
            return Page();
        }

        [BindProperty]
        public OrderDetail OrderDetail { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OrderDetail.Add(OrderDetail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
