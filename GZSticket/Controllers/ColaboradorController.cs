﻿using STICKET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STICKET.Controllers
{
    [Authorize]
    public class ColaboradorController : Controller
    {
        private STIContext _db = new STIContext();

        private List<Colaborador> ObtenerColaborador()
        {
            return _db.Colaborador.ToList();
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

            List<Colaborador> col = ObtenerColaborador();
            return View(col);
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

            List<Perfil> pe = _db.Perfiles.ToList();
            ViewBag.Perfil = pe;

            List<Especialidad> es = _db.Especialidades.ToList();
            ViewBag.Especialidad = es;

            List<Proyecto> pro = _db.Proyectos.ToList();
            ViewBag.Proyecto = pro;

            Colaborador col = new Colaborador();
            return View(col);
        }

        [HttpPost]
        public ActionResult Crear(Colaborador col)
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados.

            if (ModelState.IsValid)
            {
                _db.Colaborador.Add(col);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            List<Perfil> pe = _db.Perfiles.ToList();
            ViewBag.Perfil = pe;

            List<Especialidad> es = _db.Especialidades.ToList();
            ViewBag.Especialidad = es;

            List<Proyecto> pro = _db.Proyectos.ToList();
            ViewBag.Proyecto = pro;

            return View(col);
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

            Colaborador c = _db.Colaborador.Find(id);
            if (c == null)
            {
                return new HttpNotFoundResult();
            }
            return View(c);
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

            Colaborador c = _db.Colaborador.Find(id);
            if (c == null)
            {
                return new HttpNotFoundResult();
            }

            List<Perfil> pe = _db.Perfiles.ToList();
            ViewBag.Perfil = pe;

            List<Especialidad> es = _db.Especialidades.ToList();
            ViewBag.Especialidad = es;

            List<Proyecto> pro = _db.Proyectos.ToList();
            ViewBag.Proyecto = pro;

            return View(c);
        }

        [HttpPost]
        public ActionResult Editar(int id, Colaborador c)
        {
            //Estados:
            ViewBag.es1 = new Estado().EsCount(1);
            ViewBag.es2 = new Estado().EsCount(2);
            ViewBag.es3 = new Estado().EsCount(3);
            ViewBag.es4 = new Estado().EsCount(4);
            //Estados.

            if (ModelState.IsValid)
            {
                _db.Entry(c).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", "Colaborador", new { Id = c.Id });
            }

            List<Perfil> pe = _db.Perfiles.ToList();
            ViewBag.Perfil = pe;

            List<Especialidad> es = _db.Especialidades.ToList();
            ViewBag.Especialidad = es;

            List<Proyecto> pro = _db.Proyectos.ToList();
            ViewBag.Proyecto = pro;

            return View(c);
        }
    }
}