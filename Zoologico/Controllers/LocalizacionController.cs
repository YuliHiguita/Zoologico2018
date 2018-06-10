using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zoologico.Models;

namespace Zoologico.Controllers
{
    public class LocalizacionController : Controller
    {
        static List<Habitat> habitats = new List<Habitat>();
        //
        // GET: /Localizacion/
        public ActionResult Hábitat()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Habitat(Habitat habitat)
        {
            habitats.Add(habitat);
            return View();
        }
	}
}