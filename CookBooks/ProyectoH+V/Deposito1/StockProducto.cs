using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookBooks.Deposito1
{
    class StockProducto
    {
        private float cantidad;


        public StockProducto(float cantidad)
        {
            this.cantidad = cantidad;
        }

        public float obtenerCantidad()
        {
            return (cantidad);
        }
    }
}
