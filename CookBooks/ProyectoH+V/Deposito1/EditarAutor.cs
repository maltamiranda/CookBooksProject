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
    public partial class EditarAutor : Form
    {
        private String nombre, apellido, nacionalidad;
        private GestorAutores gestorAutores;
        private GestorLibros gestorLibros;
        private int id;
        private ModificarAutor parent;

        public EditarAutor(String nombre, String apellido, String nacionalidad, int id, GestorAutores gestorAutores, GestorLibros gestorLibros, ModificarAutor modi)
        {
            InitializeComponent();

            this.gestorAutores = gestorAutores;
            this.gestorLibros = gestorLibros;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            this.id = id;
            this.parent = modi;

            nombreBox.Text = nombre;
            apellidoBox.Text = apellido;
            nacionalidadBox.Text = nacionalidad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBManager baseDatos = new DBManager(gestorLibros, gestorAutores);
            baseDatos.inicilizar();

            baseDatos.modificarAutor(nombreBox.Text, apellidoBox.Text, nacionalidadBox.Text, id);
            Autor autor = gestorAutores.buscarAutor(nombre, apellido, nacionalidad);
            autor.modificarAutor(nombreBox.Text, apellidoBox.Text, nacionalidadBox.Text);
            parent.actualizarGridView();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
