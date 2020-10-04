using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.Models
{
    public class Factura
    {
        public int Id { set; get; }
        public int ClienteId { set; get; }
        [DataType(DataType.Date)]
        public DateTime FechaFactura { set; get; }
        public float Total { set; get; }

        // Relacion a DetalleFactura
        public ICollection<DetalleFactura> DetalleFacturaLista { set; get; }
        // Relacion a Cliente
        public Cliente Cliente { set; get; }
    }
}
