using Microsoft.AspNetCore.Mvc;
using SportStoreNetCore.Models;
using System.Linq;

namespace SportStoreNetCore.Components
{
    public class NavigationMenuViewComponent:ViewComponent
    {
        private readonly IStoreRepository _storeRepository;
        public NavigationMenuViewComponent(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(_storeRepository.Products
                .Select(p => p.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
