using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.Models
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int AlbumId { get; set; }
        public int GeneroId { get; set; }

        //Referencia a Genero

        public Genero Genero { set; get; }

        // Referencia a Album
        public Album Album { set; get; }

        // Referencia relacion a DetalleFactura
        public ICollection<DetalleFactura> DetalleFacturaLista { set; get; }

        internal static IQueryable<Cancion> AsNoTracking()
        {
            throw new NotImplementedException();
        }
    }
}
