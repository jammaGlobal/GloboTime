using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using timeZoneApp.Data;
using timeZoneApp.Models;

namespace timeZoneApp.Pages.Regions
{
    public class DetailsModel : PageModel
    {
        private readonly timeZoneApp.Data.TimeZoneAppContext _context;

        public DetailsModel(timeZoneApp.Data.TimeZoneAppContext context)
        {
            _context = context;
        }

        public Region Region { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Region = await _context.Regions.FirstOrDefaultAsync(m => m.RegionId == id);

            if (Region == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
