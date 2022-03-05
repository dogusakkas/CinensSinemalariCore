using Microsoft.AspNetCore.Mvc;

namespace CinensSinemalariCore.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
