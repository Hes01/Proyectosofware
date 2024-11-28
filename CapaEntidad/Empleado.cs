using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Empleado
    {
        public int idEmpleado { get; set; }
        public DateTime fechaIngreso { get; set; }
        public float salario { get; set; }
        public bool estado { get; set; }
        public TipoEmpleado oTipoEmpleado { get; set; }
        public Persona oPersona { get; set; }
    }
}
