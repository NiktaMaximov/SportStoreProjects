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

        public IActionResult Index(int productPage = 1)
        {
            var model = new ProductsListViewModel
            {
                Products = storeRepository.Products.OrderBy(p => p.ProductID).Skip((productPage - 1) * pageSize).Take(pageSize),
                PagingInfo = new PagingInfo { CurrentPage = productPage, ItemsPerPage = pageSize, TotalItems = storeRepository.Products.Count() }
            };
            return View(model);
        }
    }
}
