using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CinensSinemalariCore.Movie.ViewComponents
{
    public class MovieOwlCarousel : ViewComponent
    {
        MovieManager mm = new MovieManager(new EfMovieRepository());
        public IViewComponentResult Invoke()
        {
            var values = mm.GetHorizontalMovie();
            return View(values);
        }

    }
}
