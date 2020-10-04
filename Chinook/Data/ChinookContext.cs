using Chinook.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class ChinookContext:DbContext
    {
        public ChinookContext(DbContextOptions<ChinookContext> options) : base(options)
        {
        }

        public DbSet<Cancion> Cancion { set; get; }
        public DbSet<Album> Album { set; get; }
        public DbSet<Artista> Artista { set; get; }
        public DbSet<Genero> Genero { set; get; }
        public DbSet<DetalleFactura> DetalleFactura { set; get; }
        public DbSet<Factura> Factura { set; get; }
        public DbSet<Cliente> Cliente { set; get; }
        public DbSet<Empleado> Empleado { set; get; }

    }
}
