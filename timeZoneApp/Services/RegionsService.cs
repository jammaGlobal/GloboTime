using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using timeZoneApp.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace timeZoneApp.Services
{
    public class RegionsService
    {



        //public RegionsService(RegionsDbContext context)
        //{
        //    _context = context;
        //}

        public RegionsService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "regions.json");

        public IEnumerable<Region> GetRegions()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Region[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
        //public async Task DeleteAsync(long id)
        //{
        //    _context.Recipes.Remove(new Region { Id = id });
        //    await _context.SaveChangesAsync();
        //}

        //public Region Find(long id)
        //{
        //    return _context.Regions.FirstOrDefaultAsync(x => x.Id == id);
        //}

        //public Task<Region> FindAsync(long id)
        //{
        //    return _context.Recipes.FirstOrDefaultAsync(x => x.Id == id);
        //}

        //public IQueryable<Region> GetAll(int? count = null, int? page = null)
        //{
        //    var actualCount = count.GetValueOrDefault(10);

        //    return _context.Recipes
        //            .Skip(actualCount * page.GetValueOrDefault(0))
        //            .Take(actualCount);
        //}

        //public Task<Region[]> GetAllAsync(int? count = null, int? page = null)
        //{
        //    return GetAll(count, page).ToArrayAsync();
        //}

        //public async Task SaveAsync(Region recipe)
        //{
        //    var isNew = recipe.Id == default(long);

        //    _context.Entry(recipe).State = isNew ? EntityState.Added : EntityState.Modified;

        //    await _context.SaveChangesAsync();
        //}


    }
}
