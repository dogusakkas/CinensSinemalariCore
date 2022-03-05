using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CinensSinemalariCore.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nlm = new NewsLetterManager(new EfNewsLetterRepository());

        [HttpPost]
        public JsonResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            nlm.TAdd(p);
            return Json(p);
        }
    }
}
