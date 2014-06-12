﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CookBooks.Deposito1
{
    public partial class ModificarLibro : Form
    {
        private GestorLibros gestorLibros;
        private GestorAutores gestorAutores;
        private Libro libro;
        private Deposito deposito;
        private int id;

        public ModificarLibro(GestorLibros gestorLibros, GestorAutores gestorAutores, Libro libro, Deposito deposito, int id)
        {
            InitializeComponent();
            this.gestorLibros = gestorLibros;
            this.gestorAutores = gestorAutores;
            this.libro = libro;
            this.deposito = deposito;
            this.id = id;
        }

        private void ModificarLibro_Load(object sender, EventArgs e)
        {

        }

        public void mostrarDatos(String nombre, String tema, String editorial, int precio, int cantidad)
        {
            nombreBox.Text = nombre;
            temaBox.Text = tema;
            editorialBox.Text = editorial;
            precioBox.Text = precio.ToString();
            cantidadBox.Text = cantidad.ToString();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            String nombre = nombreBox.Text;
            String tema = temaBox.Text;
            String editorial = editorialBox.Text;
            int precio = int.Parse(precioBox.Text);
            int cantidad = int.Parse(cantidadBox.Text);

            DBManager baseDatos = new DBManager(gestorLibros, gestorAutores);
            baseDatos.inicilizar();

            baseDatos.modificarLibro(nombre, tema, editorial, precio, cantidad, id);
            libro.modificarLibro(nombre, tema, editorial, precio, cantidad);

            this.Close();

            deposito.actualizarFilas();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
