using Intern_Admin_Collaboration.Data;
using Microsoft.AspNetCore.Mvc;

namespace Intern_Admin_Collaboration.Controllers
{
    public class DashController : Controller
    {
        public Dashcontext s2;

        public DashController(Dashcontext s2)
        {
            this.s2 = s2;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Admindash()
        {
            var admins = s2.DashboardIntern.ToList();
            return View(admins);
        }
    }
}
