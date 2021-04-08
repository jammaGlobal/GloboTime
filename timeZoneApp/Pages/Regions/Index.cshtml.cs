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
    public class IndexModel : PageModel
    {
        private readonly timeZoneApp.Data.TimeZoneAppContext _context;

        public IndexModel(timeZoneApp.Data.TimeZoneAppContext context)
        {
            _context = context;
        }

        public IList<Region> Region { get;set; }

        public async Task OnGetAsync()
        {
            Region = await _context.Regions.ToListAsync();
        }
    }
}
