using ClubSocial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubSocial.Data
{
    public class ClubDBContext : DbContext
    {
        public ClubDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Socio> Socio { get; set; }
        public DbSet<TipoSocio> TipoSocio { get; set; }

        protected override void OnModelCreating(ModelBuilder modelCreator)
        {
            new Socio.Mapeo(modelCreator.Entity<Socio>());
            new TipoSocio.Mapeo(modelCreator.Entity<TipoSocio>());
        }
    }
}
