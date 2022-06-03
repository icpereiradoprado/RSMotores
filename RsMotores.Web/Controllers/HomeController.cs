using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RsMotores.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RsMotores.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /*public IActionResult Index()
        {
            return View();
        }*/

        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            email = "isaac@gmail.com";
            password = "123";
            if (string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(password))
            {
                return View("Error");
            }
            else if (email == "isaac@gmail.com" && password == "123")
            {
                return View();
            }
            else
            {
                return View();
            }
            
                
        }   

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
