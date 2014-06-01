using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CookBooks.Deposito1
{
    public partial class CrearAutor : Form
    {
        private GestorLibros gestorLibros;

        public CrearAutor(GestorLibros gestorLibros)
        {
            this.gestorLibros = gestorLibros;
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            DBManager baseDatos = new DBManager(gestorLibros);
            baseDatos.inicilizar();

            String nombre;
            String apellido;
            String nacionalidad;


            nombre = nombreBox.Text;
            apellido = apellidoBox.Text;
            nacionalidad = nacionalidadBox.Text;


            if (nombreBox.Text != "" & apellidoBox.Text != "" & nacionalidadBox.Text != "")
            {
                gestorLibros.crearAutor(nombre, apellido, nacionalidad);

                baseDatos.crearAutor(nombre, tema, editorial, precio, cantidad, DateTime.Now);

                deposito.actualizarFilas();
                this.Close();
            }

        }
    }
}
