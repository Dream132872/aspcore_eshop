using Microsoft.AspNetCore.Mvc;

namespace Eshop.Web.Controllers
{
    public class HomeController : Controller
    {
        private List<string> products = new List<string>()
        {
            "IPhone 13",
            "Galaxy s23",
            "IPhone 15"
        };

        // Home/Index
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowData()
        {
            // 1- ViewBag
            //ViewBag.ViewbagProducts = products;

            // 2- ViewData
            //ViewData["ViewDataProducts"] = products;

            // 3- TempData
            //TempData["Data"] = "This is tempdata";

            // 4- Strongly Type Views

            return View();
        }
    }
}