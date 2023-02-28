using Microsoft.AspNetCore.Mvc;
using SportStoreNetCore.Models;
using SportStoreNetCore.Models.ViewModels;
using System.Linq;

namespace SportStoreNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IStoreRepository storeRepository;
        public int pageSize = 4;

        public HomeController(IStoreRepository storeRepository)
        {
            this.storeRepository = storeRepository;
        }

        public IActionResult Index(string category, int productPage = 1)
        {
            var model = new ProductsListViewModel
            {
                Products = storeRepository.Products.Where(p => p.Category == category || category == null).OrderBy(p => p.ProductID).Skip((productPage - 1) * pageSize).Take(pageSize),
                PagingInfo = new PagingInfo { CurrentPage = productPage, ItemsPerPage = pageSize, TotalItems = category == null ? storeRepository.Products.Count():storeRepository.Products.Where(e => e.Category == category).Count() },
                CurrentCategory = category
            };
            return View(model);
        }
    }
}
