using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Data;
using RestaurantManagement.Models;

namespace RestaurantManagement.Pages.Tables
{
    public class IndexModel : PageModel
    {
        private readonly RestaurantManagement.Data.ApplicationDbContext _context;

        public IndexModel(RestaurantManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Table> Table { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Table = await _context.Table.ToListAsync();
        }
    }
}
