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
        public string Emain { set; get; }
        public int SoporteId { set; get; }

        //Relacion a Empleado
        public ICollection<Empleado> EmpleadosLista { set; get; }

        //Relacion de Factura
        public Factura Factura { set; get; }

    }
}
