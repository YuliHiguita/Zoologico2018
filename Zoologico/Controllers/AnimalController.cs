using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zoologico.Controllers
{
    public class AnimalController : Controller
    {
        //
        // GET: /Animal/
        public ActionResult Mamifero_T()
        {
            return View();
        }

        public ActionResult Aves()
        {
            return View();
        }

        public ActionResult Animales_A()
        {
            return View();
        }
    }
}