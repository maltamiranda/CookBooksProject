using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CookBooks.Deposito1;
using System.Collections;

namespace CookBooks
{
    public partial class Deposito : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        GestorLibros gestorLibros;
        GestorAutores gestorAutores;

        public Deposito(GestorLibros gestorLibros, GestorAutores gestorAutores)
        {
            InitializeComponent();
            this.gestorLibros = gestorLibros;
            this.gestorAutores = gestorAutores;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CrearLibro(gestorLibros, this, gestorAutores).Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            this.actualizarFilas();
        }

        public void actualizarFilas()
        {
            dataGridView1.BringToFront();
            dataGridView1.Show();
            List<Libro> librosInternos = gestorLibros.getLibros();
            dataGridView1.Rows.Clear();

            String autor = "";

            if (librosInternos != null)
            {
                foreach (Libro libro in librosInternos)
                {
                    dataGridView1.Rows.Add(libro.getNombre(), libro.getTema(), autor, libro.getEditorial(), libro.getPrecio(), libro.getCantidad(), libro.getFechaIngreso());
                }
            }

        }

        internal void mostrarFilas(List<Libro> interno) 
        {
            dataGridView1.Rows.Clear();
            String autor = "";
            foreach (Libro libro in interno)
            {
                dataGridView1.Rows.Add(libro.getNombre(), libro.getTema(), autor, libro.getEditorial(), libro.getPrecio(), libro.getPrecio(), libro.getCantidad());
            }
        }

        String libro = "";
        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }


        private void existenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new agregarLibro(libro, gestorLibros).Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            String celda = (String)dataGridView1.CurrentRow.Cells["Nombre"].Value;

            DBManager conexionBase = new DBManager(gestorLibros, gestorAutores);
            conexionBase.inicilizar();
            conexionBase.eliminarLibro("'" + celda + "'");
            gestorLibros.eliminarLibro(celda);
        }
    }
}
