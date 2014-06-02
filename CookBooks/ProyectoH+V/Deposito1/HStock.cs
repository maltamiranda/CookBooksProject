using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookBooks.Deposito1
{
    class HStock
    {
        String movimiento;
        int cantidad;
        String usuario;
        DateTime fechaHora;

        public HStock(String movimiento, int cantidad, String usuario, DateTime fechaHora) 
        {
            this.movimiento = movimiento;
            this.cantidad = cantidad;
            this.usuario = usuario;
            this.fechaHora=fechaHora;
        }

        public String getMovimiento() 
        {
            return movimiento;
        }

        public int getCantidad() 
        {
            return cantidad;
        }

        public String getUsuario() 
        {
            return usuario;
        }

        public DateTime getFechaHora() 
        {
            return fechaHora;
        }
    }
}
