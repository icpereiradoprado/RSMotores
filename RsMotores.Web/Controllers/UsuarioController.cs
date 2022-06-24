using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RsMotores.Web.Models;
namespace RsMotores.Web.Controllers
{
    public class UsuarioController : Controller
    {
        /*public List<Usuario> users = new List<Usuario>();
        public void AddUsers(Usuario user)
        {
            users.Add(new Usuario(user.Id, user.Nickname, user.Cpf, user.Email, user.Password));
        }*/
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
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection objForm)
        {
            Usuario user = new
                (
                    1,
                    objForm["nickName"].ToString(),
                    objForm["cpf"].ToString(),
                    objForm["email"].ToString(),
                    objForm["password"].ToString()
                );
            //user.AddUsers(user);
            try
            {
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Show",user);
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
