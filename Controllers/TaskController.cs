using Intern_Admin_Collaboration.Data;
using Intern_Admin_Collaboration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Intern_Admin_Collaboration.Controllers
{
    public class TaskController : Controller
    {
        private Taskcontext s1;
        public TaskController(Taskcontext s1)
        {
            this.s1 = s1;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Addtask ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Addtask (TaskdetailModel add)
        {
            if (ModelState.IsValid)
            {
                s1.Taskinterns.Add(add);
                s1.SaveChanges();
                return RedirectToAction("Addtask");
            }
            // If ModelState is not valid, return the view with validation errors
            return View(add);
        }

        public IActionResult Taskview ()
        {
            var taskintern = s1.Taskinterns.ToList();
            return View(taskintern);

        }

        public IActionResult Edittask (int id)
        {

            var data = s1.Taskinterns.Find(id);

            if (data == null)
            {
                return NotFound(); // Or handle the case where the student with the given id is not found
            }

            return View(data);
        }

        [HttpPost]
        public IActionResult Edittask (TaskdetailModel data)
        {

            s1.Taskinterns.Update(data);
            s1.SaveChanges();

            return RedirectToAction("Taskview");



        }
    }
}
