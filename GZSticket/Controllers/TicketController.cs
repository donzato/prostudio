using STICKET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STICKET.Controllers
{
    [Authorize]
    public class TicketController : Controller
    {
        private STIContext _db = new STIContext();
        private List<Ticket> ObtenerTickets()
        {
            return _db.Tickets.ToList();
        }
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
            //Estados.

            List<Ticket> t = ObtenerTickets();
            return View(t);
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
            ViewBag.Estado = estados;

            List<Depto> deptos = _db.Deptos.ToList();
            ViewBag.Depto = deptos;

            Ticket t = new Ticket();
            return View(t);
        }

        [HttpPost]
        public ActionResult Crear(Ticket t)
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados.

            if (ModelState.IsValid)
            {
                _db.Tickets.Add(t);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            List<Estado> estados = _db.Estados.ToList();
            ViewBag.Estado = estados;

            List<Depto> deptos = _db.Deptos.ToList();
            ViewBag.Depto = deptos;

            return View(t);
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

            Ticket t = _db.Tickets.Find(id);
            if (t == null)
            {
                return new HttpNotFoundResult();
            }
            return View(t);
        }
    }
}