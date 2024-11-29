using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleDePago
    {
        public int idDetallePago { get; set; }
        public decimal monto { get; set; }
        public Tarjeta oTarjeta { get; set; }
        public MedioPago oMedio { get; set; }
        public Pago oPago { get; set; }
    }
}
