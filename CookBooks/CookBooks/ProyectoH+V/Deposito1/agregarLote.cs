using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CookBooks;

namespace CookBooks.Deposito1
{
    public partial class agregarLote : Form
    {
        public GestorLibros GestorProducto;
        String producto;
        public agregarLote(String producto, GestorLibros interno)
        {
            InitializeComponent();
            this.GestorProducto = interno;
            vencimientoBox.Visible = false;
            this.producto = producto;
        }
        /*
        private void agregarLote_Load(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            String descripcion;
            int cantidad = 0;

            DateTime vencimiento;

            vencimiento = vencimientoBox.Value;
            descripcion = descripcionBox.Text;
            if (cantidadBox.Text != "")
            {
                cantidad = Convert.ToInt32(cantidadBox.Text);
                cantidad = int.Parse(cantidadBox.Text);
            }

            if (descripcionBox.Text != "" & cantidadBox.Text != "" & vencimientoBox.Visible == true)
            {
                foreach (Libro prod in GestorProducto.getLibros())
                {
                    if (prod.getNombre() == producto)
                    {
                        prod.agregarLote(descripcion, cantidad, vencimiento);
                    }
                }

                this.Close();
            }

            if (descripcionBox.Text != "" & cantidadBox.Text != "" & vencimientoBox.Visible == false)
            {
                vencimiento = new DateTime();

                foreach (Libro prod in GestorProducto.getProductos())
                {
                    if (prod.getNombre() == producto)
                    {
                        prod.agregarLote(descripcion, cantidad, vencimiento);
                    }
                }

                this.Close();
            }

        }

        private void vencimientoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            vencimientoBox.Visible = true;
        }*/
    }
}
