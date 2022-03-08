using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CinensSinemalariCore.Controllers
{
	public class AboutController : Controller
	{
		AboutManager am = new AboutManager(new EfAboutRepository());
		public IActionResult Index()
		{
			var values = am.GetList();
			return View(values);
		}
	}
}
