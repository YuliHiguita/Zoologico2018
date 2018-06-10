using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zoologico.Models;

namespace Zoologico.Controllers
{
    public class AsignacionController : Controller
    {
        static List<Asignacion> asignaciones = new List<Asignacion>();
        //
        // GET: /Asignacion/
        public ActionResult Asignacion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Asignacion(Asignacion asignacion)
        {
            asignaciones.Add(asignacion);
            return View();
        }
	}
}