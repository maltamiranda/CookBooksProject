﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CookBooks;

namespace CookBooks.Deposito1
{
    public partial class CrearLibro : Form
    {
        public GestorLibros gestorLibros;
        public Deposito deposito;

        public CrearLibro(GestorLibros gestorLibros, Deposito deposito)
        {
            InitializeComponent();
            this.gestorLibros = gestorLibros;
            this.deposito = deposito;
        }

        

        private void aceptar_Click(object sender, EventArgs e)
        {
            DBManager baseDatos = new DBManager(gestorLibros);
            baseDatos.inicilizar();

            String nombre;
            int cantidad=0;
            int precio=0;
            String tema;
            String editorial;
          

            nombre = nombreBox.Text;
            tema = temaBox.Text;
            editorial = editorialBox.Text;
            if (cantidadBox.Text != "")
            {
                cantidad = Convert.ToInt32(cantidadBox.Text);
                cantidad = int.Parse(cantidadBox.Text);
            }
            if (precioBox.Text != "")
            {
                precio = Convert.ToInt32(precioBox.Text);
                precio = int.Parse(precioBox.Text);
            }


            if (nombreBox.Text != "" & temaBox.Text != "" & editorialBox.Text != "" & cantidadBox.Text != "" & precioBox.Text != "")
            {
               gestorLibros.crearLibro(nombre, tema, editorial, precio, cantidad);

               baseDatos.crearLibro(nombre, tema, editorial, precio, cantidad, DateTime.Now);

               deposito.actualizarFilas();
               this.Close();
            }

        }

        private void nombreBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearLibro_Load(object sender, EventArgs e)
        {

        }

        private void temaBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
