using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoologico.Models
{
    public class Asignacion
    {
        public string Id_animal { get; set; }
        public string Id_habitat { get; set; }
        public string Fecha_de_ingreso { get; set; }
        public string Fecha_de_salida { get; set; }
    }
}