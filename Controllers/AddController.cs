using Intern_Admin_Collaboration.Data;

using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Addintern()
        {
            var addintern = s1.AddIntern.ToList();
            return View(addintern);
        }
    }
}
