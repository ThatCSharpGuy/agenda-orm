using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    public class Telefono
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Nombre { get; set; }

        public Contacto Contacto { get; set; }
    }
}