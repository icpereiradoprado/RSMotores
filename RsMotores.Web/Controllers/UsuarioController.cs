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
    public class UsuarioController : Controller
    {
        // GET: UsuarioController
        /*public ActionResult Index()
        {
            return View();
        }*/

        // GET: UsuarioController/Details/5
        /*public ActionResult Details(int id)
        {
            return View();
        }*/

        // GET: UsuarioController/Show/objUser
        public ActionResult Show()
        {

            //serviceUsers.GetListUsuarios().Add(user);
            /*return View(UsuarioService<Usuario>._usuarios);*/
            return View(UsuarioService.ListUsers);  
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            //UsuarioService<Usuario>._usuarios = new List<Usuario>();
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection objForm)
        { 
            try
            {
                var user = new Usuario
                (
                    1,
                    objForm["nickName"].ToString(),
                    objForm["cpf"].ToString(),
                    objForm["email"].ToString(),
                    objForm["password"].ToString()
                );
                UsuarioService.ListUsers.Add(user);
                return View("Create","Usuário cadastrado com Sucesso");
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        /*public ActionResult Edit(int id)
        {
            return View();
        }*/

        // POST: UsuarioController/Edit/5
        /*[HttpPost]
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
        }*/

        // GET: UsuarioController/Delete/5
        /*public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
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
        }*/
    }
}
