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
    public partial class ComprarLibro : Form
    {
        private GestorLibros gestorLibros;
        private GestorAutores gestorAutores;
        private Libro libro;
        private Deposito deposito;
        private int id;

        public ComprarLibro(GestorLibros gestorLibros, GestorAutores gestorAutores, Libro libro, Deposito deposito, int id)
        {
            InitializeComponent();
            this.gestorLibros = gestorLibros;
            this.gestorAutores = gestorAutores;
            this.libro = libro;
            this.deposito = deposito;
            this.id = id;

            this.mostrarDatos(libro.getNombre(), libro.getEditorial(), libro.getPrecio());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void mostrarDatos(String nombre, String editorial, int precio) {
            nombreText.Text = nombre;
            nombreText.ReadOnly = true;
            editorialText.Text = editorial;
            editorialText.ReadOnly = true;
            precioText.Text = precio.ToString();
            precioText.ReadOnly = true;
        
        
        }

        private void botonCompra_Click(object sender, EventArgs e)
        {

        }




    }
}
