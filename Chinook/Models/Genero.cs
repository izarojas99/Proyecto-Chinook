using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.Models
{
    public class Genero
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        // Referencia la relacion con Cancion
       public ICollection<Cancion> CancionLista { set; get; }

    }

   
}
