using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected readonly HttpClient httpClient;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            httpClient = new HttpClient
            {
                BaseAddress = new System.Uri(URL.BaseUrl)
            };
        }

        public IActionResult Index()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            if (ViewBag.Role == "Admin")
            {
                return View();
            }
            else if (ViewBag.Role == "Customer")
            {
                return View();
            }
           
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Sidenav()
        {
            return View("/Views/Shared/_Sidenav.cshtml");
        }
        public string GetRole()
        {
            ViewBag.Role = HttpContext.Session.GetString("Role");
            var header = HttpContext.Session.GetString("Token");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", header);
            var role = ViewBag.Role;
            var tes = User.IsInRole(role);
            return role;
        }
    }
}
