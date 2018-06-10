using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zoologico.Models;

namespace Zoologico.Controllers
{
    public class PrecioController : Controller
    {
        static List<Presencial> presenciales = new List<Presencial>();
        static List<Virtual> virtuales = new List<Virtual>();
        //
        // GET: /Precio/
        public ActionResult Presencial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Presencial(Presencial presencial)
        {
            presenciales.Add(presencial);
            return View();
        }
        //
        // GET: /Precio/
        public ActionResult Virtual()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Virtual(Virtual virtua)
        {
            virtuales.Add(virtua);
            return View();
        }
	}
}