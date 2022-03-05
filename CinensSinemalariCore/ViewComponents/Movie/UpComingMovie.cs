using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CinensSinemalariCore.ViewComponents.Movie
{
    public class UpComingMovie:ViewComponent
    {
        MovieManager mm = new MovieManager(new EfMovieRepository());
        public IViewComponentResult Invoke()
        {
            var values = mm.GetList();
            return View(values);
        }
    }
}
