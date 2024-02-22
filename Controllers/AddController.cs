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

            if (!string.IsNullOrEmpty(searchString))
            {
                interns = interns.Where(s1 => s1.firstname.Contains(searchString) || s1.lastname.Contains(searchString)).ToList();
            }

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
