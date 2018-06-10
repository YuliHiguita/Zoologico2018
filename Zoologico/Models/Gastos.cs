using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoologico.Models
{
    public class Gastos
    {
        public string Id_animal { get; set; }
        public string Costo { get; set; }
        public string Fecha_de_adquisicion { get; set; }
        public string Estado { get; set; }
    }
}