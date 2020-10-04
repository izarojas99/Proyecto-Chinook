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

        public ICollection<Genero> Generolista { set; get; }

        // Referencia a Album
        public ICollection<Album> AlbumLista { set; get; }

        // Referencia relacion a DetalleFactura
        public DetalleFactura DetalleFactura { set; get; }

    }
}
