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
        List<int> idAutores = new List<int>();

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
                idAutores.Add(autor.getId());
            }

            comboBox1.DataSource = apellidoAutores;
        }


        private void SeleccionarAutor_Load(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            String autor = comboBox1.SelectedItem.ToString();
            int indice = comboBox1.SelectedIndex;
            modificarLibro.setAutor(autor);
            //Agregamos el autor y el libro a la tabla.
            //Obtengo el id del libro
            int idLibro=modificarLibro.getIdLibro();
            int idAutor = idAutores[indice];

            DBManager bd = new DBManager(modificarLibro.getGestorLibros(),modificarLibro.getGestorAutores());
            bd.inicilizar();
            bd.autorLibro(idAutor,idLibro);
           // bd.close();


            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
