﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Data;
using RestaurantManagement.Models;

namespace RestaurantManagement.Pages.Staffs
{
    public class IndexModel : PageModel
    {
        private readonly RestaurantManagement.Data.ApplicationDbContext _context;

        public IndexModel(RestaurantManagement.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff
                .Include(s => s.Role).ToListAsync();
        }
    }
}
