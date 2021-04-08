using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using timeZoneApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timeZoneApp.Data;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace timeZoneApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly timeZoneApp.Data.TimeZoneAppContext _context;


        public string CurrentRegionName { get; set; }
        public DateTime CurrentTime { get; set; }


        //private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Region Region { get; set; }


       /* public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }*/

        public IndexModel(timeZoneApp.Data.TimeZoneAppContext context)
        {
            _context = context;
        }

        //[BindProperty]
        //public int Id { get; set; }

        //this file is called the ViewModel (MVVM)

        public void OnGet()
        {

        }
        //IActionResult
        public void OnPost()
        {
            if (ModelState.IsValid == false)
            {
                //return Page();
            }

            String searchString = Region.RegionName;

            var a = _context.Set<Region>().FromSqlInterpolated($"dbo.GetRegionName @SearchString = {searchString}");
            var b = a.AsEnumerable<Region>().First();

            Region = b;

            CurrentRegionName = b.RegionName;
            var c = b.offset;
            CurrentTime = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).Add(c);

            //TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).Add(listOfOffsets[region.ToLower()]);

            /*IQueryable<Region> storedRegions = from r in _context.Regions
                                             select r;

            

            if (!String.IsNullOrEmpty(searchString))
            {
                storedRegions = storedRegions.Where(r => r.RegionName.Contains(searchString));
            }

            var thing = new { Region = Region.RegionName };*/

            //return RedirectToPage("/Index", new { Region = Region.RegionName });
        }
    }

}
