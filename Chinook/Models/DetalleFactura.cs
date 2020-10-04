using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.Models
{
    public class DetalleFactura
    {
        public int Id { set; get; }
        public int FacturaId { set; get; }
        public int CancionId { set; get; }
        public float PrecioUnidad { set; get; }
        public int Cantidad { set; get; }

        // Relacion a Cancion
        public ICollection<Cancion> CancionLista { set; get; }
        //Relacion de Factura
        public Factura  Factura { set; get; }


    }
}
