using Microsoft.AspNetCore.Mvc;

namespace Eshop.Web.ViewComponents
{
    public class SiteHeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // retrieve data from db
            return View("SiteHeader");
        }
    }
}
