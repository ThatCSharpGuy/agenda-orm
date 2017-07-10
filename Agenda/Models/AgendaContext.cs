using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Agenda.Models
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(): base("ConnAgendaDb")
        {

        }

        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }

    }
}