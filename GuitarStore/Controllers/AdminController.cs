using GuitarStore.Data;
using GuitarStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GuitarStore.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly GuitarContext _context;

        public AdminController(GuitarContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var guitars = await _context.Guitars.Include(g => g.Category).ToListAsync();
            return View(guitars);
        }

        [HttpGet]
        public async Task<IActionResult> AddGuitar()
        {
            ViewBag.Categories = new SelectList(await _context.Categories.ToListAsync(), "CategoryID", "Type");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddGuitar(Guitar guitar)
        {
            if (ModelState.IsValid)
            {
                _context.Guitars.Add(guitar);
                await _context.SaveChangesAsync();
                TempData["Success"] = $"{guitar.Brand} added successfully.";
                return RedirectToAction("Index");
            }
            ViewBag.Categories = new SelectList(await _context.Categories.ToListAsync(), "CategoryID", "Type");
            return View(guitar);
        }

        [HttpGet]
        public async Task<IActionResult> EditGuitar(int id)
        {
            var guitar = await _context.Guitars.FindAsync(id);
            if (guitar == null) return NotFound();
            ViewBag.Categories = new SelectList(await _context.Categories.ToListAsync(), "CategoryID", "Type", guitar.CategoryID);
            return View(guitar);
        }

        [HttpPost]
        public async Task<IActionResult> EditGuitar(Guitar guitar)
        {
            if (ModelState.IsValid)
            {
                _context.Guitars.Update(guitar);
                await _context.SaveChangesAsync();
                TempData["Success"] = $"{guitar.Brand} updated successfully.";
                return RedirectToAction("Index");
            }
            ViewBag.Categories = new SelectList(await _context.Categories.ToListAsync(), "CategoryID", "Type", guitar.CategoryID);
            return View(guitar);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteGuitar(int id)
        {
            var guitar = await _context.Guitars.FindAsync(id);
            if (guitar != null)
            {
                _context.Guitars.Remove(guitar);
                await _context.SaveChangesAsync();
                TempData["Success"] = $"{guitar.Brand} deleted successfully.";
            }
            return RedirectToAction("Index");
        }
    }
}