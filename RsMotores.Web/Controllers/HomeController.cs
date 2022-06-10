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
            ErrorMessage dataError;
            var userDados = new Usuario()
            {
                Cpf="44455566677",
                Email = "admin@gmail.com",
                Nickname = "admin",
                Password ="123456",
            };
            ViewBag.Title = "Mensagem de login";
            if (string.IsNullOrWhiteSpace(userDados.Email) && string.IsNullOrWhiteSpace(userDados.Password))
            {
                dataError = new ErrorMessage(3);
                ViewBag.Msg = dataError.Msg;
                ViewBag.Color = "red";
                ViewBag.Icon = "error";
                return View("Error", dataError);
            }
            else
            {
                if (email.Equals(userDados.Email) && password.Equals(userDados.Password))
                {
                    ViewBag.Msg = "Login Válido";
                    ViewBag.Color = "green";
                    ViewBag.Icon = "success";
                    return View(userDados);
                }
                else
                {
                    dataError = new ErrorMessage(1);
                    ViewBag.Condition = true;
                    ViewBag.Msg = dataError.Msg ;
                    ViewBag.Color = "red";
                    ViewBag.Icon = "error";
                    return View("Error", dataError);
                }
            }
            return View();
            
            
                
        }   

        public IActionResult Privacy()
        {
            return View();
        }

        /*[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
