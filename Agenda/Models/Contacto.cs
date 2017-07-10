using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Telefono> Telefonos { get; set; }
    }

}