using STICKET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STICKET.Controllers
{
    public class PacificoController : Controller
    {
        private STIContext _db = new STIContext();

        public ActionResult Index()
        {
            return View();
        }
    }
}

