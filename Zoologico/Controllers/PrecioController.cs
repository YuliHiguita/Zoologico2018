using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zoologico.Controllers
{
    public class PrecioController : Controller
    {
        //
        // GET: /Precio/
        public ActionResult Presencial()
        {
            return View();
        }
         
        //
        // GET: /Precio/
        public ActionResult Virtual()
        {
            return View();
        }
	}
}