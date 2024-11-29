using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int idVenta { get; set; }
        //public DateTime fecha { get; set; }
        public float total { get; set; }
        public bool estado { get; set; }
        public Farmacia oFarmacia { get; set; }
        public Empleado idEmpleado { get; set; }
        public Cliente oCliente { get; set; }
        public Pedido oPedido { get; set; }
    }
}
