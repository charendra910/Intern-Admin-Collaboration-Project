using Intern_Admin_Collaboration.Data;
using Intern_Admin_Collaboration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Intern_Admin_Collaboration.Controllers
{
    public class AddInternSalaryController: Controller
    {
        private AddInternSalarycontext s1;

        public AddInternSalaryController(AddInternSalarycontext s1) 
        {
            this.s1 = s1;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Internview()
        {
            var addintern = s1.AddInternSalary.ToList();
            return View(addintern);

        }
        public IActionResult AddInternSalary()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInternSalary(AddInternSalaryModel data )
        {
            if (ModelState.IsValid)
            {
                s1.AddInternSalary.Add(data);
                s1.SaveChanges();
                return RedirectToAction("Internview");
            }
            // If ModelState is not valid, return the view with validation errors
            return View(data);
        }

        public IActionResult SalaryEdit(int Id)
        {

            var data = s1.AddInternSalary.Find(Id);

            if (data == null)
            {
                return NotFound(); // Or handle the case where the student with the given id is not found
            }

            return View(data);
        }

        [HttpPost]
        public IActionResult SalaryEdit(AddInternSalaryModel data)
        {

            s1.AddInternSalary.Update(data);
            s1.SaveChanges();

            return RedirectToAction("Internview");
        }

        public IActionResult SalaryDelete(int Id)
        {
            var data = s1.AddInternSalary.Find(Id);
            if (data != null)
            {
                s1.AddInternSalary.Remove(data);
                s1.SaveChanges();
            }
            return RedirectToAction("Internview"); // Replace "Index" with the appropriate action name or URL
        }


    }
}
