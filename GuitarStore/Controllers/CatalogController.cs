using Microsoft.AspNetCore.Mvc;
using GuitarStore.Data;
using GuitarStore.Models;
using Microsoft.EntityFrameworkCore;

namespace GuitarStore.Controllers
{
    public class CatalogController : Controller
    {
        private readonly GuitarContext _context;

        public CatalogController(GuitarContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string brand, int? categoryId, decimal? minPrice, decimal? maxPrice)
        {
            var guitars = _context.Guitars.Include(g => g.Category).AsQueryable();

            if (!string.IsNullOrEmpty(brand))
                guitars = guitars.Where(g => g.Brand.Contains(brand));

            if (categoryId.HasValue)
                guitars = guitars.Where(g => g.CategoryID == categoryId.Value);

            if (minPrice.HasValue)
                guitars = guitars.Where(g => g.Price >= minPrice.Value);

            if (maxPrice.HasValue)
                guitars = guitars.Where(g => g.Price <= maxPrice.Value);

            ViewBag.Categories = await _context.Categories.ToListAsync();

            return View(await guitars.ToListAsync());
        }
        public async Task<IActionResult> ImageOnly(int id)
        {
            var guitar = await _context.Guitars.FindAsync(id);
            if (guitar == null) return NotFound();
            return View(guitar);
        }

    }
}
