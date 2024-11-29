using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public decimal precioLista { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public Categoria oCategoria { get; set; }
        public int stock { get; set; }
        public String rutaImagen { get; set; }
        public String nombreImagen {  get; set; }

    }
}


