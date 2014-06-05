using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CookBooks.Deposito1
{
    public class GestorAutores
    {
        public List<Autor> Autores = new List<Autor>();
        public List<Autor> AutoresBuscados = new List<Autor>();

        public List<Autor> getAutores()
        {
            return Autores;
        }

        public void borrarAutores()
        {
            Autores = null;
        }

        /*
        public List<Autores> buscarLibros(String nombre)
        {
            LibrosBuscados.Clear();
            foreach (Libro libro in Libros)
            {
                if (libro.nombre == nombre)
                {
                    LibrosBuscados.Add(libro);
                }
            }
            return LibrosBuscados;
        }

         * 
        public void eliminarLibro(String nombre)
        {
            for (int i = 0; i < Libros.Count; i++)
            {
                if (Libros[i].nombre == nombre)
                {
                    Libros.RemoveAt(i);
                    i--;
                }
            }
        }
         * 
         * */
        
        /*
        public void crearAutor(String nombre, String tema, String editorial, int precio, int cantidad)
        {
            DateTime fechaIngreso = DateTime.Now;
            //DateTime vencimiento = new DateTime(2014, 12, 4);
            this.crearLibro(nombre, tema, editorial, precio, cantidad, fechaIngreso);
        }
    
         * 
         * /**/
        
        public void crearAutor(String nombre, String apellido, String nacionalidad)
        {
            //DateTime vencimiento = new DateTime(2014, 12, 4);
            Autores.Add(new Autor(nombre, apellido, nacionalidad));

        }
         
    }
}
