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
    public partial class agregarLibro : Form
    {
        public GestorLibros gestorLibros;
        String libro;
        public agregarLibro( String libro, GestorLibros interno)
        {
            InitializeComponent();
            this.gestorLibros = interno;
            this.libro = libro;
        }

        private void agregarCantidad_Load(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            int cantidad = 0;

            if (cantidadBox.Text != "")
            {
                cantidad = Convert.ToInt32(cantidadBox.Text);
                cantidad = int.Parse(cantidadBox.Text);
            }

            if (cantidadBox.Text != "")
            {
                foreach (Libro libr in gestorLibros.getLibros())
                {
                    if (libr.getNombre() == libro)
                    {
                        libr.agregarCantidad(cantidad);
                        }
                    }
                }

                this.Close();
            }
        
    }
}
