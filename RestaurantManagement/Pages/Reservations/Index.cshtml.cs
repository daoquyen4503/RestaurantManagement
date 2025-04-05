using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Data;
using RestaurantManagement.Models;

namespace RestaurantManagement.Pages.Reservations
{
    public class IndexModel : PageModel
    {
        private readonly RestaurantManagement.Data.ApplicationDbContext _context;

        public IndexModel(RestaurantManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Reservation> Reservation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Reservation = await _context.Reservation
                .Include(r => r.Customer)
                .Include(r => r.Table).ToListAsync();
        }
    }
}
