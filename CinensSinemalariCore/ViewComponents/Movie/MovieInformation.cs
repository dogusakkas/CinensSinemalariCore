using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CinensSinemalariCore.ViewComponents.Movie
{
    public class MovieInformation:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
