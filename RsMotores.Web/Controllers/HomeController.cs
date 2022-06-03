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
            ViewBag.Title = "Mensagem de login";
            if (string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(password))
            {
                ViewBag.Msg = "Os campos E-mail e senha estão vazios! ";
                ViewBag.Color = "red";
                ViewBag.Icon = "error";
            }
            else
            {
                if (email.Equals("isaac@gmail.com") && password.Equals("123"))
                {
                    ViewBag.Msg = "Login Válido";
                    ViewBag.Color = "green";
                    ViewBag.Icon = "success";
                }
                else
                {
                    ViewBag.Condition = true;
                    ViewBag.Msg = "Login Inválido";
                    ViewBag.Color = "red";
                    ViewBag.Icon = "error";
                    return View("~/Views/Login/Token.cshtml");
                }
            }
            return View();
            
            
                
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
