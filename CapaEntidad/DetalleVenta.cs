using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public int cantidad { get; set; }
        public float descuento { get; set; }
        public float subTotal { get; set; }
        public Venta oVenta { get; set; }
        public Producto oProducto { get; set; }

        //idtransaccion pago 
        public List<DetalleVenta> oDetalleVenta { get; set; }
    }
}
