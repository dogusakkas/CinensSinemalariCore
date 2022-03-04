using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CinensSinemalariCore.Controllers
{
    
    public class MovieController : Controller
    {
        MovieManager mm = new MovieManager(new EfMovieRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult OwlCarouselPartial()
        {
            var values = mm.GetList();
            return PartialView(values);
        }
    }
}
