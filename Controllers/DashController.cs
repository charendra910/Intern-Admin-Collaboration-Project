using Intern_Admin_Collaboration.Data;
using Intern_Admin_Collaboration.Migrations.approvedcontextMigrations;
using Intern_Admin_Collaboration.Models;
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

        public IActionResult Admindash()
        {
            var admins = s2.DashboardIntern.ToList();
            return View(admins);
        }  

        public IActionResult Adminedit ()
        {
            return View();
        }

        public IActionResult Admincreate () 
        
        {
            return View();
        }

        [HttpPost]
        public IActionResult Admincreate(DashboardModel dash)
        {
            if(ModelState.IsValid) 
            {
                s2.DashboardIntern.Add(dash);
                s2.SaveChanges();
                return RedirectToAction("Admincreate");
            }
            // If ModelState is not valid, return the view with validation errors
            return View(dash);

        }

     
    }
}
