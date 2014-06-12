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
    public partial class SeleccionarAutor : Form
    {
        GestorAutores gestorAutores;
        ModificarLibro modificarLibro;

        public SeleccionarAutor(GestorAutores gestorAutores, ModificarLibro modificarLibro)
        {
            InitializeComponent();
            this.gestorAutores = gestorAutores;
            this.modificarLibro = modificarLibro;
            cargarAutores();
        }

        public void cargarAutores() 
        {
            List<Autor> autores = gestorAutores.getAutores();
            List<String> apellidoAutores = new List<string>();
            comboBox1.Items.Clear();

            foreach (Autor autor in autores) 
            {
                apellidoAutores.Add(autor.getApellido());
            }

            comboBox1.DataSource = apellidoAutores;
        }


        private void SeleccionarAutor_Load(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            String autor = comboBox1.SelectedItem.ToString();
            modificarLibro.setAutor(autor);
            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
