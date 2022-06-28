using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RsMotores.Web.Models;
using RsMotores.Web.Services;

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

        public ActionResult Show()
        {
            return View(ProdutoService.ListProducts);
        }
            

        // GET: ProductController/Create
        public ActionResult Create(string msg)
        {
            return View(msg);
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection objForm)
        {
            string price = objForm["price"].ToString().Replace(".",",");

            double priceConverted = double.Parse(price);
            
            
            try
            {
                var product = new Product
                (
                    1,
                    objForm["nameProduct"].ToString(),
                    priceConverted,
                    int.Parse(objForm["quantity"])
                );
                ProdutoService.ListProducts.Add(product);
                return View("Create", "Produto cadastrado com sucesso");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        /*public ActionResult Edit(int id)
        {
            return View();
        }*/

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
