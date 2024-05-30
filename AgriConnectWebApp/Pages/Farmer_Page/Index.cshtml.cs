using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AgriConnectWebApp.Data;
using AgriConnectWebApp.Models;

namespace AgriConnectWebApp.Pages.Farmer_Page
{
    public class IndexModel : PageModel
    {
        private readonly AgriConnectWebApp.Data.ApplicationDbContext _context;

        public IndexModel(AgriConnectWebApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Farmer> Farmer { get;set; }

        public async Task OnGetAsync()
        {
            Farmer = await _context.Farmers.ToListAsync();
        }
    }
}
