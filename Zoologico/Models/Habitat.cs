using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoologico.Models
{
    public class Habitat
    {

        public string Clase { get; set; }
        public string Id_habitat { get; set; }
        public string Tipo { get; set; }
        public string Tamaño_en_metros_cuadrados { get; set; }
        public string Capacidad { get; set; }
        public string Visitable { get; set; }
    }
}