using RegistroArticulosConDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroArticulosConDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> articulos { get; set; }
        public DbSet<Personas> personas { get; set; }     
        public DbSet<Cotizaciones> cotizaciones { get; set; }

        // base("ConStr") para pasar la conexion a la clase base de EntityFramework 
        public Contexto() : base("ConStr") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
