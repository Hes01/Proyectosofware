using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Anulacion
    {
        public int idAnulacion { get; set; }
        public  DateTime fechaHora { get; set; }
        public Venta oVenta { get; set; }
        public Empleado oEmpleado { get; set; }
        public DetalleVenta oDetalle { get; set; }
    }
}
