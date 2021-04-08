using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using timeZoneApp.Data;
using timeZoneApp.Models;

namespace timeZoneApp.Pages.Regions
{
    public class CreateModel : PageModel
    {
        private readonly timeZoneApp.Data.TimeZoneAppContext _context;

        public CreateModel(timeZoneApp.Data.TimeZoneAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Region Region { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Check if region exists



            _context.Regions.Add(Region);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
