using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zoologico.Controllers
{
    public class FinancieroController : Controller
    {
        //
        // GET: /Financiero/
        public ActionResult Gastos()
        {
            return View();
        }
        public ActionResult Ingresos()
        {
            return View();
        }
	}
}