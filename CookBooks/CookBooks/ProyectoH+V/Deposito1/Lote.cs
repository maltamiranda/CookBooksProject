using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookBooks.Deposito1
{
    public class Lote
    {
        String descripcion;
        int cantidad;
        DateTime vencimiento;
        DateTime fechaIngreso;

        public Lote(String descripcion, int cantidad, DateTime fechaIngreso, DateTime vencimiento) 
        {
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.vencimiento = vencimiento;
            this.fechaIngreso = fechaIngreso;
        }

        public String getDescripcion()
        {
            return descripcion;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public DateTime getVencimiento()
        {
            return vencimiento;
        }

        public DateTime getFechaIngreso()
        {
            return fechaIngreso;
        }

        public void setFechaIngreso(DateTime nuevaFecha) 
        {
            fechaIngreso = nuevaFecha;
        }

        public void agregarCantidad(int nuevaCantidad) 
        {
            cantidad = cantidad + nuevaCantidad;
        }
    }
}
