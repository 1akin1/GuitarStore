using GuitarStore.Models;
using Microsoft.AspNetCore.Mvc;
using GuitarStore.Extensions;

namespace GuitarStore.Controllers
{
    public class CartController : Controller
    {
        private const string SessionKey = "Cart";

        [HttpPost]
        public IActionResult Add(int GuitarID, string Brand, decimal Price, int Quantity, string ImageUrl)
        {
            List<CartItem> cart = HttpContext.Session.GetObject<List<CartItem>>(SessionKey) ?? new List<CartItem>();

            var existingItem = cart.FirstOrDefault(c => c.GuitarID == GuitarID);
            if (existingItem != null)
            {
                existingItem.Quantity += Quantity;
            }
            else
            {
                cart.Add(new CartItem
                {
                    GuitarID = GuitarID,
                    Brand = Brand,
                    Price = Price,
                    Quantity = Quantity,
                    ImageUrl = ImageUrl
                });
            }

            HttpContext.Session.SetObject(SessionKey, cart);
            TempData["CartMessage"] = $"{Brand} added to cart!";
            return RedirectToAction("Index", "Catalog");
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>(SessionKey);
            if (cart != null)
            {
                var itemToRemove = cart.FirstOrDefault(c => c.GuitarID == id);
                if (itemToRemove != null)
                {
                    cart.Remove(itemToRemove);
                    HttpContext.Session.SetObject(SessionKey, cart);
                    TempData["CartMessage"] = $"{itemToRemove.Brand} removed from cart.";
                }
            }

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>(SessionKey) ?? new List<CartItem>();
            return View(cart);
        }

        [HttpPost]
        public IActionResult Increase(int id)
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>(SessionKey);
            var item = cart?.FirstOrDefault(c => c.GuitarID == id);
            if (item != null)
            {
                item.Quantity++;
                HttpContext.Session.SetObject(SessionKey, cart);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Decrease(int id)
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>(SessionKey);
            var item = cart?.FirstOrDefault(c => c.GuitarID == id);
            if (item != null)
            {
                if (item.Quantity > 1)
                {
                    item.Quantity--;
                    HttpContext.Session.SetObject(SessionKey, cart);
                }
                else
                {
                    // Remove item if quantity would drop to 0
                    cart!.Remove(item);
                    HttpContext.Session.SetObject(SessionKey, cart);
                    TempData["CartMessage"] = $"{item.Brand} removed from cart.";
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>(SessionKey) ?? new List<CartItem>();
            if (!cart.Any())
                return RedirectToAction("Index");

            // Placeholder: In a real app, this would show an order form
            return View("Checkout", cart);
        }
    }
}
