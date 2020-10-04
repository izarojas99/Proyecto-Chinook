using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.Models
{
    public class Cliente
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public int Telefono { set; get; }
        public string Email { set; get; }
        public int EmpleadoId { set; get; }
        
        //Relacion a Empleado
        public Empleado Empleado { set; get; }

        //Relacion de Factura
        public ICollection<Factura> FacturaLista { set; get; }

    }
}
