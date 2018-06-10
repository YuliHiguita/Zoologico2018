using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zoologico.Models;

namespace Zoologico.Controllers
{
    public class AnimalController : Controller
    {
        static List<Animal> animales = new List<Animal>();
        static List<Mamifero> mamiferos = new List<Mamifero>();
        static List<Aves> aves_a = new List<Aves>();
        //
        // GET: /Animal/
        public ActionResult Mamifero_T()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Mamifero_T(Mamifero mamifero)
        {
            mamiferos.Add(mamifero);
            return View();
        }

        public ActionResult Aves()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Aves(Aves aves)
        {
            aves_a.Add(aves);
            return View();
        }

        public ActionResult Animales_A()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Animales_A( Animal animal)
        {
            animales.Add(animal);
            return View();
        }

    }
}