using Intern_Admin_Collaboration.Data;
using Intern_Admin_Collaboration.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Intern_Admin_Collaboration.Controllers
{

    public class ApproveController : Controller
    {
        private approvedcontext s1;

        public ApproveController(approvedcontext s1)
        {
            this.s1 = s1;
        }

        public IActionResult Approveview()
        {
            var addintern = s1.ApprovedInterns.ToList();
            return View(addintern);

        }

        public IActionResult Approveinterns()
        {

            return View();
        }


        public IActionResult Editleave(int id)
        {

            var data = s1.ApprovedInterns.Find(id);

            if (data == null)
            {
                return NotFound(); // Or handle the case where the student with the given id is not found
            }

            return View(data);
        }

        [HttpPost]
        public IActionResult Editleave(ApprovedModel data)
        {

            s1.ApprovedInterns.Update(data);
            s1.SaveChanges();

            return RedirectToAction("Approveview");

        }

        //public async Task<IActionResult> Approveleave(string searchString)
        //{
        //    var interns = await s1.ApprovedInterns.ToListAsync();

        //    if (!string.IsNullOrEmpty(searchString))
        //    {
        //        searchString = searchString.ToLower(); // Convert search string to lowercase

        //        interns = interns.Where(s => s.firstname.ToLower().Contains(searchString) || s.lastname.ToLower().Contains(searchString)).ToList();
        //    }

        //    return View(interns);
        //}


        public async Task<IActionResult> Approveleave(string searchString)
        {
            var interns = await s1.ApprovedInterns.ToListAsync();
            bool dataFound = true; // Flag to indicate if data was found

            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower(); // Convert search string to lowercase

                interns = interns.Where(s => s.firstname.ToLower().Contains(searchString) || s.lastname.ToLower().Contains(searchString)).ToList();

                if (interns.Count == 0)
                {
                    dataFound = false; // Set flag to false if no data is found
                }
            }

            ViewBag.DataFound = dataFound; // Pass the flag to the view
            return View(interns);
           
        }


        [HttpPost]
        public IActionResult Approveinterns(ApprovedModel approve)
        {
            if (ModelState.IsValid)
            {
                s1.ApprovedInterns.Add(approve);
                s1.SaveChanges();
                return RedirectToAction("Approveview");
            }
            return View(approve);
        }


        /*public IActionResult Delete(int id)
        {
            var data = s1.ApprovedInterns.Find(id);
            if (data != null)
            {
                s1.ApprovedInterns.Remove(data);
                s1.SaveChanges();
            }
            return RedirectToAction("Approveview"); // Replace "Index" with the appropriate action name or URL
        }*/



    }
}

