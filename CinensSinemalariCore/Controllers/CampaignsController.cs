using Microsoft.AspNetCore.Mvc;

namespace CinensSinemalariCore.Controllers
{
    public class CampaignsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
