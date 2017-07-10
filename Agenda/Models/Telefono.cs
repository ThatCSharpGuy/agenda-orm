using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    [Table("Telefonos")]
    public class Telefono
    {
        public int Id { get; set; }
        [MaxLength(16)]
        public string Numero { get; set; }
        [MaxLength(40)]
        public string Nombre { get; set; }

        public Contacto Contacto { get; set; }
        public int ContactoId { get; set; }
    }
}