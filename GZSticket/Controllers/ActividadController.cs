using STICKET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STICKET.Controllers
{
    [Authorize]
    public class ActividadController : Controller
    {
        private STIContext _db = new STIContext();
        private List<Actividad> ObtenerActividades()
        {
            return _db.Actividades.ToList();
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

            List<Actividad> p = ObtenerActividades();
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

            List<Ticket> tickets = _db.Tickets.ToList();
            ViewBag.Ticket = tickets;

            Actividad p = new Actividad();
            return View(p);
        }

        [HttpPost]
        public ActionResult Crear(Actividad p)
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados.

            if (ModelState.IsValid)
            {
                _db.Actividades.Add(p);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            List<Ticket> tickets = _db.Tickets.ToList();
            ViewBag.Ticket = tickets;

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

            Actividad p = _db.Actividades.Find(id);
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

            Actividad p = _db.Actividades.Find(id);
            if (p == null)
            {
                return new HttpNotFoundResult();
            }

            List<Ticket> tickets = _db.Tickets.ToList();
            ViewBag.Ticket = tickets;

            return View(p);
        }

        [HttpPost]
        public ActionResult Editar(int id, Actividad p)
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
                return RedirectToAction("Index", "Actividad", new { Id = p.Id });
            }

            List<Ticket> tickets = _db.Tickets.ToList();
            ViewBag.Ticket = tickets;

            return View(p);
        }
    }
}