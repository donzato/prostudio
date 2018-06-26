using STICKET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STICKET.Controllers
{
    [Authorize]
    public class ProyectoController : Controller
    {
        private STIContext _db = new STIContext();
        private List<Proyecto> ObtenerProyectos()
        {
            return _db.Proyectos.ToList();
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

            List<Proyecto> p = ObtenerProyectos();
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

            List<Estado> estados = _db.Estados.ToList();
            ViewBag.estados = estados;

            List<Colaborador> colaboradors = _db.Colaborador.ToList();
            ViewBag.colaboradors = colaboradors;

            List<Actividad> actividads = _db.Actividades.ToList();
            ViewBag.actividads = actividads;

            Proyecto p = new Proyecto();
            return View(p);
        }

        [HttpPost]
        public ActionResult Crear(Proyecto p)
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados.

            if (ModelState.IsValid)
            {
                _db.Proyectos.Add(p);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            List<Estado> estados = _db.Estados.ToList();
            ViewBag.estados = estados;

            List<Colaborador> colaboradors = _db.Colaborador.ToList();
            ViewBag.colaboradors = colaboradors;

            List<Actividad> actividads = _db.Actividades.ToList();
            ViewBag.actividads = actividads;

            return View(p);
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

            Proyecto p = _db.Proyectos.Find(id);
            if (p == null)
            {
                return new HttpNotFoundResult();
            }
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

            Proyecto p = _db.Proyectos.Find(id);
            if (p == null)
            {
                return new HttpNotFoundResult();
            }

            List<Estado> estados = _db.Estados.ToList();
            ViewBag.estados = estados;

            List<Colaborador> colaboradors = _db.Colaborador.ToList();
            ViewBag.colaboradors = colaboradors;

            List<Actividad> actividads = _db.Actividades.ToList();
            ViewBag.actividads = actividads;

            return View(p);
        }

        [HttpPost]
        public ActionResult Editar(int id, Proyecto p)
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
                return RedirectToAction("Index", "Proyecto", new { Id = p.Id });
            }

            List<Estado> estados = _db.Estados.ToList();
            ViewBag.estados = estados;

            List<Colaborador> colaboradors = _db.Colaborador.ToList();
            ViewBag.colaboradors = colaboradors;

            List<Actividad> actividads = _db.Actividades.ToList();
            ViewBag.actividads = actividads;

            return View(p);
        }
    }
}