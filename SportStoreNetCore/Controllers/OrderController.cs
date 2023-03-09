using Microsoft.AspNetCore.Mvc;
using SportStoreNetCore.Models;
using System.Linq;

namespace SportStoreNetCore.Controllers
{
    public class OrderController : Controller
    {
        public Cart Cart;

        public OrderController(Cart cart)
        {
            Cart = cart;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Order());
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if(Cart.Lines.Count == 0)
            {
                ModelState.AddModelError("", "Ваша корзина пуста");
            }
            if(ModelState.IsValid)
            {
                order.Lines = Cart.Lines.ToArray();
                Cart.Clear();
                return RedirectToPage("/Completed", new { orderId = order.OrderID });
            }
            else
            {
                return View();
            }
        }
    }
}
