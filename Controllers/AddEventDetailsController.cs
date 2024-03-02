using Intern_Admin_Collaboration.Data;
using Intern_Admin_Collaboration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Intern_Admin_Collaboration.Controllers
{
    public class AddEventDetailsController: Controller
    {
        private AddEventDetailscontext s9;

        public AddEventDetailsController(AddEventDetailscontext s9) 
        {
            this.s9 = s9;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Eventview()
        {
            var addevent = s9.AddEventDetails.ToList();
            return View(addevent);

        }
        public IActionResult AddEventDetails()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEventDetails(AddEventDetailsModel data )
        {
            if (ModelState.IsValid)
            {
                s9.AddEventDetails.Add(data);
                s9.SaveChanges();
                return RedirectToAction("Eventview");
            }
            // If ModelState is not valid, return the view with validation errors
            return View(data);
        }

        public IActionResult EventEdit(int Id)
        {

            var data = s9.AddEventDetails.Find(Id);

            if (data == null)
            {
                return NotFound(); // Or handle the case where the student with the given id is not found
            }

            return View(data);
        }

        [HttpPost]
        public IActionResult EventEdit(AddEventDetailsModel data)
        {

            s9.AddEventDetails.Update(data);
            s9.SaveChanges();

            return RedirectToAction("Eventview");
        }

        public IActionResult EventDelete(int Id)
        {
            var data = s9.AddEventDetails.Find(Id);
            if (data != null)
            {
                s9.AddEventDetails.Remove(data);
                s9.SaveChanges();
            }
            return RedirectToAction("Eventview"); // Replace "Index" with the appropriate action name or URL
        }


    }
}
