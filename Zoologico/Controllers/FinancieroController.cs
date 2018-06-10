using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zoologico.Models;

namespace Zoologico.Controllers
{
    public class FinancieroController : Controller
    {

        static List<Gastos> gastoss = new List<Gastos>();
        static List<Ingresos> ingresoss = new List<Ingresos>();
        //
        // GET: /Financiero/
        public ActionResult Gastos()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Gastos(Gastos gastos)
        {
            gastoss.Add(gastos);
            return View();
        }
        public ActionResult Ingresos()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ingresos(Ingresos ingresos)
        {
            ingresoss.Add(ingresos);
            return View();
        }
	}
}