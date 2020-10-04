using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.Models
{
    public class Empleado
    {
        public int Id { set; get; }
        public string Nombres { set; get; }
        public string Apellidos { set; get; }
        public string Cargo { set; get; }
        public int JefeDirecto { set; get; }
        public int Telefono { set; get; }
        public string  Email { set; get; } 

        //Relacion de Cliente
        public Cliente Cliente { set; get; }

        //Relacion a Empleado
        public ICollection<Empleado> EmpleadoLista { set; get; }
    }
}
