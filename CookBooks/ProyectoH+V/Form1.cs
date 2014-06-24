using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CookBooks.Deposito1;

namespace CookBooks
{
    public partial class Form1 : Form
    {
        GestorLibros gestorProducto;
        GestorAutores gestorAutores;
        Deposito deposito;

        public Form1(GestorLibros gestorProducto, GestorAutores gestorAutores)
        {
            InitializeComponent();
            this.gestorAutores = gestorAutores;
            this.gestorProducto = gestorProducto;
        }

        //public Deposito deposito = new Deposito(gestorProducto);

        private void button1_Click(object sender, EventArgs e)
        {
            deposito = new Deposito(gestorProducto, gestorAutores);
            AddFormInPanel(deposito);
        }

        private void AddFormInPanel(object formHijo)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel.Controls.Add(fh);
            this.panel.Tag = fh;
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Caja());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button2.Text == "Cerrar Sesion")
            {
                button2.Text = "Iniciar Sesion";
                this.Text = "Cookbooks, bienvenido Anonimo";
            }
            else
            {
                new LogIn(gestorProducto, gestorAutores, deposito, this).Show();
            }
        }

        public void sesionIniciada(String usuario)
        {
            button2.Text = "Cerrar Sesion";
            this.Text = "Cookbooks, bienvenido " + usuario;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CrearCuenta(gestorProducto, gestorAutores).Show();
        }
    }
}
