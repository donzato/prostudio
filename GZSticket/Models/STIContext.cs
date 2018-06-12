using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace STICKET.Models
{
    public class STIContext : DbContext
    {
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Comuna> Comunas { get; set; }
        public DbSet<Depto> Deptos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Perfil> Perfiles { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Region> Regiones { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }
    }
}