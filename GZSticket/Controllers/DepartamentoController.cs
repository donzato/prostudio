using STICKET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STICKET.Controllers
{
    [Authorize]
    public class DepartamentoController : Controller
    {
        private STIContext _db = new STIContext();
        private List<Depto> ObtenerDeptos()
        {
            return _db.Deptos.ToList();
        }

        [HttpGet]
        public ActionResult Index()
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados.

            List<Depto> p = ObtenerDeptos();
            return View(p);
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

            List<Sucursal> sucursales = _db.Sucursales.ToList();
            ViewBag.Sucursal = sucursales;

            Depto p = new Depto();
            return View(p);
        }

        [HttpPost]
        public ActionResult Crear(Depto p)
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados.

            if (ModelState.IsValid)
            {
                _db.Deptos.Add(p);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            List<Sucursal> sucursales = _db.Sucursales.ToList();
            ViewBag.Sucursal = sucursales;

            return View(p);
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

            Depto p = _db.Deptos.Find(id);
            if (p == null)
            {
                return new HttpNotFoundResult();
            }

            List<Sucursal> sucursales = _db.Sucursales.ToList();
            ViewBag.Sucursal = sucursales;

            return View(p);
        }

        [HttpPost]
        public ActionResult Editar(int id, Depto p)
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados.

            if (ModelState.IsValid)
            {
                _db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", "Departamento", new { Id = p.Id });
            }

            List<Sucursal> sucursales = _db.Sucursales.ToList();
            ViewBag.Sucursal = sucursales;

            return View(p);
        }
        public ActionResult Ver(int id)
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados.

            Depto p = _db.Deptos.Find(id);
            if (p == null)
            {
                return new HttpNotFoundResult();
            }
            return View(p);
        }
    }
}