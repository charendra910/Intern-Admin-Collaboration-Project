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

        public IActionResult Approveleave()
        {
            var addintern = s1.ApprovedInterns.ToList();
            return View(addintern);
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
       

     
        //[HttpPost]
        //public IActionResult Approveinterns(ApprovedModel approve)
        //{
        //    s1.ApprovedInterns.Add(approve);
        //    s1.SaveChanges();
        //    return RedirectToAction("Addindex");
        //}

        [HttpPost]
        public IActionResult Approveinterns(ApprovedModel approve)
        {
            if (ModelState.IsValid)
            {
                s1.ApprovedInterns.Add(approve);
                s1.SaveChanges();
                return RedirectToAction("Approveview");
            }
            // If ModelState is not valid, return the view with validation errors
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


//[HttpPost]
//public IActionResult Addintern(Interns intern)
//{
//    s1.AddIntern.Add(intern);
//    s1.SaveChanges();
//    return RedirectToAction("Addindex");
//}