using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Comprobante
    {
        public int idComprobante { get; set; }
        public int nroComprobante { get; set; }
        //public DateTime fechaEmision { get; set; }
        public TipoComprobante oTipoComprobante { get; set; }
        public Pago oPago { get; set; }
    }
}
