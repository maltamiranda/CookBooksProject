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
    public partial class verAutores : Form

    {
        private GestorLibros gestorLibros;
        private GestorAutores gestorAutores;
        private Libro libro;
        private Deposito deposito;
        private int id;
         public verAutores(GestorLibros gestorLibros, GestorAutores gestorAutores, Libro libro, Deposito deposito, int id)
        {
            InitializeComponent();
            this.gestorLibros = gestorLibros;
            this.gestorAutores = gestorAutores;
            this.libro = libro;
            this.deposito = deposito;
            this.id = id;

             //LLamo al metodo que me devuelve el id de los autores apartir del id del libro

            DBManager baseDatos = new DBManager(gestorLibros, gestorAutores);
            baseDatos.inicilizar();
            List<int> idAutores=baseDatos.getIdAutores(id);
             //Con los id de los autores consigo los apellidos
            List<String> apellidoAutores = new List<String>();
             foreach (int i in idAutores){
                 String apellido = baseDatos.obtenerApellidoAutor(i);
                 apellidoAutores.Add(apellido);
             }


             int cantidad = apellidoAutores.Count;

             if (cantidad<1){
             
             }
             else if (cantidad == 1)
             {
                 textBox1.Text = apellidoAutores[0];
                 textBox1.ReadOnly = true;
             }
             else if (cantidad == 2)
             {
                 textBox1.Text = apellidoAutores[0];
                 textBox1.ReadOnly = true;
                 textBox2.Text = apellidoAutores[1];
                 textBox2.ReadOnly = true;
             }
             else if (cantidad == 3)
             {
                 textBox1.Text = apellidoAutores[0];
                 textBox1.ReadOnly = true;
                 textBox2.Text = apellidoAutores[1];
                 textBox2.ReadOnly = true;
                 textBox3.Text = apellidoAutores[2];
                 textBox3.ReadOnly = true;
             }
             else if (cantidad == 4)
             {
                 textBox1.Text = apellidoAutores[0];
                 textBox1.ReadOnly = true;
                 textBox2.Text = apellidoAutores[1];
                 textBox2.ReadOnly = true;
                 textBox3.Text = apellidoAutores[2];
                 textBox3.ReadOnly = true;
                 textBox4.Text = apellidoAutores[3];
                 textBox4.ReadOnly = true;
             }
            // textBox2.Text = apellidoAutores[1];
             //textBox3.Text = apellidoAutores[2];
             //textBox4.Text = apellidoAutores[3];

             

            //this.mostrarDatos(libro.getNombre(), libro.getTema(), libro.getEditorial(), libro.getPrecio(), libro.getCantidad());
        }

         private void listView1_SelectedIndexChanged(object sender, EventArgs e)
         {

         }
    }
}
