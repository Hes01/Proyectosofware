using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Farmacia
    {
        public int idFarmacia { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public bool estado { get; set; }
        public Ciudad oCiudad { get; set; }
    }
}
