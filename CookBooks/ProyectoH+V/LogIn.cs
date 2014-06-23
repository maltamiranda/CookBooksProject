using CookBooks.Deposito1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CookBooks
{
    public partial class LogIn : Form
    {

        private DBManager dbm;
        private Deposito deposito;
        private Form1 form1;

        public LogIn(GestorLibros gl, GestorAutores ga , Deposito deposito, Form1 form1)
        {
            InitializeComponent();
            dbm = new DBManager(gl, ga);
            this.deposito = deposito;
            this.form1 = form1;
            dbm.inicilizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dbm.logInValidation(userBox.Text, pwBox.Text))
            {
                form1.sesionIniciada(userBox.Text);
                this.Close();
            }else
            {
                loginFail.Visible = true;
                loginFail.Text = "SELECT user FROM usuarios WHERE " +
                    "user='" + userBox.Text + "' AND pw='" + pwBox.Text + "'";
            }
        }
    }
}
