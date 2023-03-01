using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportStoreNetCore.Infrastructure;
using SportStoreNetCore.Models;
using System.Linq;

namespace SportStoreNetCore.Pages
{
    public class CartModel : PageModel
    {
        private readonly IStoreRepository _storeRepository;

        public CartModel(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long productId, string returnUrl)
        {
            Product product = _storeRepository.Products.FirstOrDefault(p => p.ProductID == productId);
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(product, 1);
            HttpContext.Session.SetJson("cart", Cart);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
