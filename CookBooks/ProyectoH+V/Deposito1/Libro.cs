﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookBooks.Deposito1
{
    public class Libro
    {
        public String nombre;
        private String tema;
        private String editorial;
        private int precio;
        private int cantidad = 0;
        private DateTime fecha_ingreso = new DateTime();
        private Autor autor;


        public Libro(String nombre, String tema, Autor autor, String editorial, int precio, int cantidad, DateTime fecha_ingreso)
        {
            this.nombre = nombre;
            this.tema = tema;
            this.autor = autor;
            this.editorial = editorial;
            this.precio = precio;
            this.cantidad = cantidad;
            this.fecha_ingreso = fecha_ingreso;
        }

        public void modificarLibro(String nombre, String tema, Autor autor, String editorial, int precio, int cantidad) 
        {
            this.nombre = nombre;
            this.tema = tema;
            this.autor = autor;
            this.editorial = editorial;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public void agregarAutor(Autor autor)
        {
            this.autor = autor;
        }

        public Autor getAutor() 
        {
            return autor;
        }

        public void agregarCantidad(int cant) 
        {
            cantidad = cantidad + cant;
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getTema()
        {
            return tema;
        }

        public String getEditorial()
        {
            return editorial;
        }


        public int getPrecio()
        {
            return precio;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public DateTime getFechaIngreso()
        {
            return fecha_ingreso;
        }
    }
}