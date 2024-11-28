﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public DateTime fechaPedido { get; set; }
        public string direccionEntrega { get; set; }
        public bool estado { get; set; }
        public CarritoCompra oCarrito { get; set; }
    }
}
