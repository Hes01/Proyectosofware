using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Persona
    {
        public int idPersona { get; set; }
        public string nombreCompleto { get; set; }
        public string nroDocumento { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public bool estado { get; set; }
        public TipoDocumento oTipoDoc { get; set; }
    }
}
