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
        private GestorAutores gestorAutores;
        private Deposito deposito;

        public CrearAutor(GestorAutores gestorAutores1, Deposito deposito1)
        {
            gestorAutores = gestorAutores1;
            deposito = deposito1;
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            DBManager baseDatos = new DBManager(gestorAutores);
            baseDatos.inicilizar();

            String nombre;
            String apellido;
            String nacionalidad;


            nombre = nombreBox.Text;
            apellido = apellidoBox.Text;
            nacionalidad = nacionalidadBox.Text;

            //Llamar al gestor de autores
            if (nombreBox.Text != "" & apellidoBox.Text != "" & nacionalidadBox.Text != "")
            {
                gestorAutores.crearAutor(nombre, apellido, nacionalidad);

                baseDatos.crearAutor(nombre, apellido, nacionalidad);

                deposito.actualizarFilas();
                this.Close();
            }
            
        }
    }
}
