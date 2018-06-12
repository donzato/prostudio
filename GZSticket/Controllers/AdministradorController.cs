using STICKET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STICKET.Controllers
{
    public class AdministradorController : Controller
    {
        private STIContext _db = new STIContext();
        private List<Proyecto> ObtenerProyectos()
        {
            return _db.Proyectos.ToList();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Proyecto> proyectos = ObtenerProyectos();
            return View(proyectos);
        }

        [HttpGet]
        public ActionResult Crear()
        {
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
        public ActionResult Listar()
        {
            List<Proyecto> p = ObtenerProyectos();
            return View(p);
        }

        [HttpGet]
        public ActionResult Ver(int id)
        {
            Proyecto p = _db.Proyectos.Find(id);
            if (p == null)
            {
                return new HttpNotFoundResult();
            }
            return View(p);
        }
    }
}