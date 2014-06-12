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
    public partial class ModificarAutor : Form
    {
        private GestorAutores gestorAutores;
        private GestorLibros gestorLibros;
        private Deposito deposito;

        public ModificarAutor(GestorAutores gestorAutores1, GestorLibros gestorLibros, Deposito deposito1)
        {
            InitializeComponent();
            
            gestorAutores = gestorAutores1;
            deposito = deposito1;
            this.gestorLibros = gestorLibros;
            this.actualizarGridView();
        }

        public void actualizarGridView()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.BringToFront();
            dataGridView1.Show();
            List<Autor> autoresInternos = gestorAutores.getAutores();

            //dataGridView1.Rows.Add("asd", "asd", "asd");

            if (autoresInternos != null)
            {
                foreach (Autor autor in autoresInternos)
                {
                    dataGridView1.Rows.Add(autor.getNombre(), autor.getApellido(), autor.getNacionalidad());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre;
            String apellido;
            String nacionalidad;
            int id;
            Autor autor;

            nombre = (String)dataGridView1.CurrentRow.Cells["nombre"].Value;
            apellido = (String)dataGridView1.CurrentRow.Cells["apellido"].Value;
            nacionalidad = (String)dataGridView1.CurrentRow.Cells["nacionalidad"].Value;

            DBManager conexionBase = new DBManager(gestorLibros, gestorAutores);
            conexionBase.inicilizar();
            id = conexionBase.obteneridAutor(nombre, apellido, nacionalidad);


            autor = gestorAutores.buscarAutor(nombre, apellido, nacionalidad);
            

            //EditarAutor editarAutor = 
            new EditarAutor(nombre, apellido,nacionalidad, id, gestorAutores, gestorLibros, this).Show();
            //modificarLibro.mostrarDatos(celda, tema, editorial, precio, cantidad);
            //modificarLibro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nombre = (String)dataGridView1.CurrentRow.Cells["nombre"].Value;
            String apellido = (String)dataGridView1.CurrentRow.Cells["apellido"].Value;
            String nacionalidad = (String)dataGridView1.CurrentRow.Cells["nacionalidad"].Value;

            DBManager conexionBase = new DBManager(gestorLibros, gestorAutores);
            conexionBase.inicilizar();
            int id = conexionBase.obteneridAutor(nombre, apellido, nacionalidad);

            conexionBase.eliminarAutor(id);
            gestorAutores.eliminarAutor(nombre, apellido,nacionalidad);
            this.actualizarGridView();
        }

    }
    
}
