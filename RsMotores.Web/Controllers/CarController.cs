using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RsMotores.Web.Models;

namespace RsMotores.Web.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CarDisplay()
        {
            ViewBag.Id = 1;
            ViewData["Title"] = "Oi";
            return View();
        }

        public IActionResult CardCars()
        {
            return View();
        }
    }
}
