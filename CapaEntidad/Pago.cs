using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pago
    {
        public int idPago { get; set; }
        //public DateTime fecha { get; set; }
        public float total { get; set; }
        public int codigoPago { get; set; }
        public bool estado { get; set; }
        public Empleado oEmpleado { get; set; }
        public Venta oVenta { get; set; }
    }
}
