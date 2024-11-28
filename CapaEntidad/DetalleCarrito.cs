using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class DetalleCarrito
    {
        public int idDetalleCarrito { get; set; }
        public int cantidad { get; set; }
        public float subtotal { get; set; } 
        public bool estado { get; set; }
        public Producto oProducto {  get; set; }
        public CarritoCompra oCarrito { get; set; }
    }
}
