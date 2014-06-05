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

        public Form1(GestorLibros gestorProducto, GestorAutores gestorAutores)
        {
            InitializeComponent();
            this.gestorAutores = gestorAutores;
            this.gestorProducto = gestorProducto;
        }

        //public Deposito deposito = new Deposito(gestorProducto);

        private void button1_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Deposito(gestorProducto,gestorAutores));
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
    }
}
