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
    public class DetailsModel : PageModel
    {
        private readonly AgriConnectWebApp.Data.ApplicationDbContext _context;

        public DetailsModel(AgriConnectWebApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Farmer Farmer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Farmer = await _context.Farmers.FirstOrDefaultAsync(m => m.FarmerId == id);

            if (Farmer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
