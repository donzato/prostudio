using STICKET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace STICKET.Controllers
{
    [Authorize]
    public class SucursalController : Controller
    {
        private STIContext _db = new STIContext();
        private List<Sucursal> ObtenerSucursal()
        {
            return _db.Sucursales.ToList();
        }

        [HttpGet]
        public ActionResult Index()
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados

            List<Sucursal> s = ObtenerSucursal();
            return View(s);
        }

        [HttpGet]
        public ActionResult Crear()
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados.

            List<Comuna> Comunas = _db.Comunas.ToList();
            ViewBag.Comuna = Comunas;

            Sucursal s = new Sucursal();
            return View(s);
        }

        [HttpPost]
        public ActionResult Crear(Sucursal s)
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados.

            if (ModelState.IsValid)
            {
                _db.Sucursales.Add(s);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            List<Comuna> Comunas = _db.Comunas.ToList();
            ViewBag.Comuna = Comunas;

            return View(s);
        }

        [HttpGet]
        public ActionResult Ver(int id)
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados.

            Sucursal s = _db.Sucursales.Find(id);
            if (s == null)
            {
                return new HttpNotFoundResult();
            }
            return View(s);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados.

            Sucursal s = _db.Sucursales.Find(id);
            if (s == null)
            {
                return new HttpNotFoundResult();
            }

            List<Comuna> Comunas = _db.Comunas.ToList();
            ViewBag.Comuna = Comunas;

            return View(s);
        }

        [HttpPost]
        public ActionResult Editar(int id, Sucursal s)
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados.

            if (ModelState.IsValid)
            {
                _db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", "Sucursal", new { Id = s.Id });
            }

            List<Comuna> Comunas = _db.Comunas.ToList();
            ViewBag.Comuna = Comunas;

            return View(s);
        }
    }
}