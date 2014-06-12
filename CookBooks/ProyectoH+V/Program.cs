using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CookBooks.Deposito1;

namespace CookBooks
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GestorLibros gestorLibros = new GestorLibros();
            GestorAutores gestorAutores = new GestorAutores();
            DBManager cargar = new DBManager(gestorLibros,gestorAutores);
            cargar.inicilizar();
            cargar.cargarLibros();
            cargar.cargarAutores();
            DateTime fecha = DateTime.Now;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(gestorLibros,gestorAutores));
        }
    }
}
