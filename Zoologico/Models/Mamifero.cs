using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zoologico.Models
{
    public class Mamifero
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Especie { get; set; }
        public string Subespecie { get; set; }
        public string Paisdeorigen { get; set; }
        public string Descripción { get; set; }
        public string Número_de_patas { get; set; }
        public string Carnivoro { get; set; } 
    }
}