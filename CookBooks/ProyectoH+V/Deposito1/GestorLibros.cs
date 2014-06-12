using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CookBooks.Deposito1
{
    public class GestorLibros
    {
        public List<Libro> Libros = new List<Libro>();
        public List<Libro> LibrosBuscados = new List<Libro>();
        private Libro libroBuscado;

        public List<Libro> getLibros()
        {
            return Libros;
        }

        public void borrarLibros()
        {
            Libros = null;
        }


        public Libro buscarLibro(String nombre)
        {
            //LibrosBuscados.Clear();
            foreach (Libro libro in Libros)
            {
                if (libro.nombre == nombre)
                {
                    libroBuscado = libro;
                    //LibrosBuscados.Add(libro);
                }
            }
            return libroBuscado;
        }

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

        public void crearLibro(String nombre, String tema, String editorial, int precio, int cantidad)
        {
            DateTime fechaIngreso = DateTime.Now;
            //DateTime vencimiento = new DateTime(2014, 12, 4);*/
            this.crearLibro(nombre, tema, editorial, precio, cantidad, fechaIngreso);
        }

        public void crearLibro(String nombre, String tema, String editorial, int precio, int cantidad, DateTime fechaIngreso)
        {
            //DateTime vencimiento = new DateTime(2014, 12, 4);*/
            Libros.Add(new Libro(nombre, tema, editorial, precio, cantidad, fechaIngreso));

        }
    }
}
