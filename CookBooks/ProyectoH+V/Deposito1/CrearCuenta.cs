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
    public partial class CrearCuenta : Form
    {

        private GestorAutores ga;
        private GestorLibros gl;

        public CrearCuenta(GestorLibros gl, GestorAutores ga)
        {
            this.gl = gl;
            this.ga = ga;
            InitializeComponent();
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Cliente");
            comboBox1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            espacioError.Visible = false;
            pwError.Visible = false;
            userError.Visible = false;
            DBManager db = new DBManager(gl, ga);
            db.inicilizar();
            if (userBox.Text == "" || pwBox.Text == "" || pwconfirmarBox.Text == ""
                && mailBox.Text == "" || direccionBox.Text == "")
            {
                espacioError.Visible = true;
            }
            else
            {
                if (pwBox.Text == pwconfirmarBox.Text)
                {
                    if (db.isUserValid(userBox.Text))
                    {
                        int userId;
                        if (comboBox1.Text == "Admin")
                        {
                            userId = 1;
                        }
                        else
                        {
                            userId = 2;
                        }
                        db.altaUsuario(userBox.Text, pwBox.Text, mailBox.Text,
                            direccionBox.Text, userId);
                        this.Close();
                    }
                    else
                    {
                        userError.Visible = true;
                    }
                }
                else
                {
                    pwError.Visible = true;
                    if (!db.isUserValid(userBox.Text))
                    {
                        userError.Visible = true;
                    }
                }
            }
        }

       

        
    }
}
