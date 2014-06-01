using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookBooks.Deposito1
{
    class Autor
    {
        private String nombre;
        private String apellido;
        private String nacionalidad;

        public Autor(String nombre, String apellido, String nacionalidad) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getApellido()
        {
            return apellido;
        }

        public String getNacionalidad()
        {
            return nacionalidad;
        }

    }
}
