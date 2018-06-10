using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zoologico.Models;

namespace Zoologico.Controllers
{
    public class EnfermeriaController : Controller
    {
        static List<Enfermeria> enfermerias = new List<Enfermeria>();
        //
        // GET: /Enfermeria/
        public ActionResult Enfermeria()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Enfermeria(Enfermeria enfermeria)
        {
            enfermerias.Add(enfermeria);
            return View();
        }
	}
}