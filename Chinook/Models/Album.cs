using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.Models
{
    public class Album
    {
        public int Id { set; get; }
        public string Titulo { set; get; }
        public int ArtistaId { set; get; }

        // Referencia la relacion a Cancion
        public ICollection<Cancion> CancionLista { get; set; }

        // Referencia a Artista
        public Artista Artista { set; get; }




    }

   

}
