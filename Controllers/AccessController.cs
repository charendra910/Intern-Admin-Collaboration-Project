using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Intern_Admin_Collaboration.Models;
using System.Threading.Tasks;

namespace Intern_Admin_Collaboration.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;

            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(IALogin modelLogin)
        {
            // Define valid email/password combinations
            var validCredentials = new Dictionary<string, string>
            {
                { "user@example.com", "123" },
                { "roni@gmail.com", "111" },
                { "another@example.com", "password" }, // Add more as needed
            };

            // Check if the provided email/password combination is valid
            if (validCredentials.TryGetValue(modelLogin.Email, out var expectedPassword) &&
                modelLogin.PassWord == expectedPassword)
            {
                List<Claim> claims = new List<Claim>() {
                    new Claim(ClaimTypes.NameIdentifier, modelLogin.Email),
                    new Claim("Otherproperties", "Example Role")
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = modelLogin.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), properties);

                return RedirectToAction("Index", "Home");
            }

            ViewData["ValidateMessage"] = "User Not Found!";
            return View();
        }
    }
}
