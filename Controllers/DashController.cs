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
            var addadmin = s2.DashboardIntern.ToList();
            return View(addadmin);
        }

      

        public IActionResult Admincreate () 
        
        {
            return View();
        }

        [HttpPost]
        public IActionResult Admincreate(DashboardModel dash)
        {
            if (ModelState.IsValid)
            {
                s2.DashboardIntern.Add(dash);
                s2.SaveChanges();
                return RedirectToAction("Admincreate");
            }
            // If ModelState is not valid, return the view with validation errors
            return View(dash);

        }

        public IActionResult Adminupdate (int id)
        {

            var data = s2.DashboardIntern.Find(id);

            if (data == null)
            {
                return NotFound(); // Or handle the case where the student with the given id is not found
            }

            return View(data);
        }

        [HttpPost]
        public IActionResult Adminupdate (DashboardModel data)
        {

            s2.DashboardIntern.Update(data);
            s2.SaveChanges();

            return RedirectToAction("Adminedit");



        }

    }
}
