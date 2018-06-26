using STICKET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace STICKET.Controllers
{
    public class LoginController : Controller
    {
        STIContext _db = new STIContext();

       private Perfil ObtenerPerfil(string x)
        {
            return (from perfil in _db.Perfiles
                    where perfil.Nombre == x
                    select perfil).ToList().First();
        }

        [HttpGet]
        public ActionResult Index()
        {
            Login l = new Login();
            return View(l);
        }

        [HttpPost]
        public ActionResult Index(Login u)
        {
            Login x = _db.Logins.FirstOrDefault(us => (us.Nombre == u.Nombre) && (us.Clave == u.Clave));

            if(x == null)
            {
                return RedirectToAction("Index", "Login");
            }

            Perfil p = ObtenerPerfil(u.Nombre);

            if (ModelState.IsValid)
            {
                Login c = _db.Logins.FirstOrDefault(us => (us.Nombre == u.Nombre) &&  (us.Clave == u.Clave));

                if (c != null)
                {
                    FormsAuthentication.SetAuthCookie(p.Nombre, true);

                    HttpContext.Session["Nombre"] = u.Nombre;

                    if (p.CargoId == 1 )
                    {
                        HttpContext.Session["EsAdmin"] = "true";
                        HttpContext.Session["EsColaborador"] = "false";
                        HttpContext.Session["EsUsuario"] = "false";
                        return RedirectToAction("Index", "Proyecto");
                    }

                    if (p.CargoId == 2)
                    {
                        HttpContext.Session["EsAdmin"] = "false";
                        HttpContext.Session["EsColaborador"] = "true";
                        HttpContext.Session["EsUsuario"] = "false";
                        return RedirectToAction("Index", "Actividad");
                    }

                    if (p.CargoId == 3)
                    {
                        HttpContext.Session["EsAdmin"] = "false";
                        HttpContext.Session["EsColaborador"] = "false";
                        HttpContext.Session["EsUsuario"] = "true";
                        return RedirectToAction("Index", "Ticket");
                    }
                    return RedirectToAction("Index", "Login");
                }
                ModelState.AddModelError("", "Credenciales Invalidas");
                return View(u);
            }
            return View(u);
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}