using Intern_Admin_Collaboration.Data;
using Intern_Admin_Collaboration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Intern_Admin_Collaboration.Controllers
{

    public class AddController : Controller
    {
        private Addcontext s1;

        public AddController(Addcontext s1)
        {
            this.s1 = s1;
        }

        public IActionResult Index()
        {
            return View();
        }
        

        //public IActionResult Showinterns ()
        //{
        //    var addintern = s1.AddIntern.ToList();
        //    return View(addintern);

        //}

        public async Task<IActionResult> ShowInterns(string searchString)
        {
            var interns = await s1.AddIntern.ToListAsync();
            bool dataFound = true;

            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();
                interns = interns.Where(s => s.firstname.ToLower().Contains(searchString) || s.lastname.ToLower().Contains(searchString)).ToList();

                if (interns.Count == 0)
                {
                    dataFound = false; // Set flag to false if no data is found
                }

            }


            ViewBag.DataFound = dataFound;
            return View(interns);
        }

       

        public IActionResult Addintern()
        {
            var addintern = s1.AddIntern.ToList();
            return View(addintern);
        }

        [HttpPost]
        public IActionResult Addintern(Interns intern)
        {
            s1.AddIntern.Add(intern);
            s1.SaveChanges();
            return RedirectToAction("Showinterns"); //Addindex
        }

    }
}
