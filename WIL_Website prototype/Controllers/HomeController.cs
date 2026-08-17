using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WIL_Website_prototype.Models;

namespace WIL_Website_prototype.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {           
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Resources()
        {
            return View();
        }

        public IActionResult Support()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            var model = new Clientdashboard
            {
                OpenTickets = 4,
                NetworkHealthScore = 92,
                NextMaintenanceDate = new DateTime(2026, 8, 20),
                InvoiceStatus = "Paid"
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult ContactUs()
        {        
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new Login());
        }

        [HttpPost]
        public IActionResult Login(Login model)
        {
            if (string.IsNullOrWhiteSpace(model.Email) || string.IsNullOrWhiteSpace(model.Password))
            {
                ViewBag.ErrorMessage = "Please enter your email and password.";
                return View(model);
            }

            if (!PrototypeUserStore.TryLogin(model.Email, model.Password, out var user))
            {
                ViewBag.ErrorMessage = "Invalid email or password.";
                return View(model);
            }

            TempData["SuccessMessage"] = $"Welcome back, {user!.Name}!";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new Register());
        }

        [HttpPost]
        public IActionResult Register(Register model)
        {
            if (string.IsNullOrWhiteSpace(model.Name) ||
                string.IsNullOrWhiteSpace(model.Surname) ||
                string.IsNullOrWhiteSpace(model.Email) ||
                string.IsNullOrWhiteSpace(model.Password))
            {
                ViewBag.ErrorMessage = "Please fill in all fields.";
                return View(model);
            }

            if (model.Password != model.Confirmpassword)
            {
                ViewBag.ErrorMessage = "Passwords do not match.";
                return View(model);
            }

            if (!PrototypeUserStore.TryRegister(model, out var errorMessage))
            {
                ViewBag.ErrorMessage = errorMessage;
                return View(model);
            }

            TempData["SuccessMessage"] = "Registration successful! Please sign in with your new email and password.";
            return RedirectToAction(nameof(Login));
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View(new ForgotPassword());
        }

        [HttpPost]
        public IActionResult ForgotPassword(ForgotPassword model)
        {
            if (string.IsNullOrWhiteSpace(model.Email))
            {
                ViewBag.ErrorMessage = "Please enter your email address.";
                return View(model);
            }

            if (PrototypeUserStore.EmailExists(model.Email))
            {
                TempData["SuccessMessage"] =
                    "If an account exists for that email, password reset instructions have been sent. (Prototype: no email is sent yet.)";
            }
            else
            {
                TempData["SuccessMessage"] =
                    "If an account exists for that email, password reset instructions have been sent.";
            }

            return RedirectToAction(nameof(Login));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
