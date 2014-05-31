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

        public Deposito(GestorLibros gestorLibros)
        {
            InitializeComponent();
            this.gestorLibros = gestorLibros;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CrearLibro(gestorLibros, this).Show();
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

        private void historico_Click(object sender, EventArgs e)
        {
            dataGridView2.BringToFront();
            dataGridView2.Show();
            List<HStock> historicos = GestorHStock.getHistoricos();
            dataGridView2.Rows.Clear();

            if (historicos != null)
            {
                foreach (HStock historico in historicos)
                {
                    dataGridView2.Rows.Add(historico.getMovimiento(), historico.getCantidad(), historico.getUsuario(), historico.getFechaHora());
                }
            }
        }
    }
}
