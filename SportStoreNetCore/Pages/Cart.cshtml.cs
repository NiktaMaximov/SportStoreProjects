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

        public CartModel(IStoreRepository storeRepository, Cart cartServices)
        {
            _storeRepository = storeRepository;
            Cart = cartServices;
        }

        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(long productId, string returnUrl)
        {
            Product product = _storeRepository.Products.FirstOrDefault(p => p.ProductID == productId);
            Cart.AddItem(product, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long productId, string returnUrl)
        {
            Cart.RemoveItem(Cart.Lines.First(cl => cl.Product.ProductID == productId).Product);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
