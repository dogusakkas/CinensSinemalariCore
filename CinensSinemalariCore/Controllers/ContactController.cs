using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CinensSinemalariCore.Controllers
{
	public class ContactController : Controller
	{
		ContactManager cm = new ContactManager(new EfContactRepository());

		[HttpPost]
		public JsonResult ContactPopUp(Contact p)
		{
			p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.ContactStatus = true;
			cm.TAdd(p);
			return Json(p);
		}
	}
}
