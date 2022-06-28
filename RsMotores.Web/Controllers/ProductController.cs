using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RsMotores.Web.Models;

namespace RsMotores.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        /*public ActionResult Index()
        {
            return View();
        }*/

        // GET: ProductController/Details/5
        /*public ActionResult Details(int id)
        {
            return View();
        }*/

        public ActionResult Show(Product product)
        {
            return View(product);
        }
            

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection objForm)
        {
            string price = objForm["price"].ToString().Replace(".",",");

            double priceConverted = double.Parse(price);
            
            Product product = new Product
                (
                    1,
                    objForm["nameProduct"].ToString(),
                    priceConverted,
                    int.Parse(objForm["quantity"])
                ) ;
            try
            {
                return RedirectToAction("show", product);
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
