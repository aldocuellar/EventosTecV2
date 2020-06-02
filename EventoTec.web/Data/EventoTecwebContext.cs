using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventoTec.web.Models.entities;

namespace EventoTec.web.Data
{
    public class EventoTecwebContext : DbContext
    {
        public EventoTecwebContext (DbContextOptions<EventoTecwebContext> options)
            : base(options)
        {
        }

        public DbSet<EventoTec.web.Models.entities.City> City { get; set; }

        public DbSet<EventoTec.web.Models.entities.Event> Event { get; set; }

        public DbSet<EventoTec.web.Models.entities.Client> Client { get; set; }
    }
}
