using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Tarjeta
    {
        public int idTarjeta { get; set; }
        public string nroCuenta { get; set; }
        public bool estado { get; set; }
        public Cliente oCliente { get; set; }
    }
}
