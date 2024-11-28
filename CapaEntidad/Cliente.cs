using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public bool estado { get; set; }
        public Persona oPersona { get; set; }
        public TipoCliente oTipoCliente { get; set; }
    }
}
