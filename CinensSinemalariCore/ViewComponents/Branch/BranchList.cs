using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CinensSinemalariCore.ViewComponents.Branch
{
    public class BranchList:ViewComponent
    {
        BranchManager bm = new BranchManager(new EfBranchRepository());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetList();
            return View(values);
        }
    }
}
