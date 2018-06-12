using STICKET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STICKET.Controllers
{
    public class UsuarioController : Controller
    {
        private STIContext _db = new STIContext();
        private List<Ticket> ObtenerTickets()
        {
            return _db.Tickets.ToList();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Ticket> tickets = ObtenerTickets();
            return View(tickets);
        }

        [HttpGet]
        public ActionResult Crear()
        {
            List<Estado> estados = _db.Estados.ToList();
            ViewBag.estados = estados;

            List<Depto> deptos = _db.Deptos.ToList();
            ViewBag.deptos = deptos;

            Ticket t = new Ticket();
            return View(t);
        }

        [HttpPost]
        public ActionResult Crear(Ticket t)
        {
            if (ModelState.IsValid)
            {
                _db.Tickets.Add(t);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            List<Estado> estados = _db.Estados.ToList();
            ViewBag.estados = estados;

            List<Depto> deptos = _db.Deptos.ToList();
            ViewBag.deptos = deptos;

            return View(t);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            List<Ticket> t = ObtenerTickets();
            return View(t);
        }

        [HttpGet]
        public ActionResult Ver(int id)
        {
            Ticket t = _db.Tickets.Find(id);
            if (t == null)
            {
                return new HttpNotFoundResult();
            }
            return View(t);
        }
    }
}