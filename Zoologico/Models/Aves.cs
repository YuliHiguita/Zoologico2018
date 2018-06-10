using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoologico.Models
{
    public class Aves
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Especie { get; set; }
        public string Subespecie { get; set; }
        public string Paisdeorigen { get; set; }
        public string Descripción { get; set; }
        public string Tipo_de_vuelo { get; set; } 
    }
}