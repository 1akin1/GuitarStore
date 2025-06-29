using GuitarStore.Models;
using Microsoft.AspNetCore.Mvc;
using GuitarStore.Extensions;

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
            }
        }

        return RedirectToAction("Index");
    }

    public IActionResult Index()
    {
        var cart = HttpContext.Session.GetObject<List<CartItem>>(SessionKey) ?? new List<CartItem>();
        return View(cart);
    }

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

    public IActionResult Decrease(int id)
    {
        var cart = HttpContext.Session.GetObject<List<CartItem>>(SessionKey);
        var item = cart?.FirstOrDefault(c => c.GuitarID == id);
        if (item != null && item.Quantity > 1)
        {
            item.Quantity--;
            HttpContext.Session.SetObject(SessionKey, cart);
        }
        return RedirectToAction("Index");
    }

}
