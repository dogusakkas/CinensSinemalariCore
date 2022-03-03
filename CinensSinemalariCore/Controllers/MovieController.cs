using Microsoft.AspNetCore.Mvc;

namespace CinensSinemalariCore.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult OwlCarouselPartial()
        {
            return PartialView();
        }
    }
}
