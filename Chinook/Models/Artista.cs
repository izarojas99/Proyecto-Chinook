using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.Models
{
    public class Artista
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        //Referencia a relacion Album
        public ICollection<Album> AlbumLista { set; get; }


    }
}
