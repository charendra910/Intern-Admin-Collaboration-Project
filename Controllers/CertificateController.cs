using Microsoft.AspNetCore.Mvc;
using Intern_Admin_Collaboration.Data;
using Intern_Admin_Collaboration.Models;


namespace Intern_Admin_Collaboration.Controllers
{
    public class CertificateController : Controller
    {
        private Certificatecontext c1;
        public CertificateController(Certificatecontext c1)
        {
            this.c1 = c1;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCertificate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCertificate(CertificateModel add)
        {
            if (ModelState.IsValid)
            {
                c1.Certificatedetails.Add(add);
                c1.SaveChanges();
                return RedirectToAction("AddCertificate");
            }
            // If ModelState is not valid, return the view with validation errors
            return View(add);
        }

        public IActionResult Certificateview()
        {
            var certiview = c1.Certificatedetails.ToList();
            return View(certiview);

        }

       
        public IActionResult Editcertificate (int id)
        {

            var data = c1.Certificatedetails.Find(id);

            if (data == null)
            {
                return NotFound(); // Or handle the case where the student with the given id is not found
            }

            return View(data);
        }

        [HttpPost]
        public IActionResult Editcertificate (CertificateModel data)
        {

            c1.Certificatedetails.Update(data);
            c1.SaveChanges();

            return RedirectToAction("Certificateview");



        }
    }
}
