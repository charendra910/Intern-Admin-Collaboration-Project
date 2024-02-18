using Intern_Admin_Collaboration.Data;
using Intern_Admin_Collaboration.Models;

using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        public IActionResult Approveinterns(ApprovedModel approve)
        {
            s1.ApprovedInterns.Add(approve);
            s1.SaveChanges();
            return RedirectToAction("Addindex");
        }

        public IActionResult Delete(int id)
        {
            var data = s1.ApprovedInterns.Find(id);
            if (data != null)
            {
                s1.ApprovedInterns.Remove(data);
                s1.SaveChanges();
            }
            return RedirectToAction("Approveview"); // Replace "Index" with the appropriate action name or URL
        }


    }
}


//[HttpPost]
//public IActionResult Addintern(Interns intern)
//{
//    s1.AddIntern.Add(intern);
//    s1.SaveChanges();
//    return RedirectToAction("Addindex");
//}