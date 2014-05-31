using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using CookBooks.Deposito1;


namespace CookBooks
{
    class DBManager
    {
        MySqlConnection conexion;
        String servidor = "localhost";
        String basededatos = "cookbooks";
        String usuario = "root";
        String contraseña = "12345";
        MySqlDataReader rdr = null;
        int precioLibro;
        int cantidadLibro;
        int idLibros;
        int ultimoIdLibro;
        String nombreLibro;
        String temaLibro;
        String editorialLibro;
        DateTime fechaIngreso;
        GestorLibros gestorLibros;

        public DBManager(GestorLibros gestorLibros) 
        {
            this.gestorLibros = gestorLibros;
        }
        
        
        public void inicilizar()
        {
            String Conexionstring = "SERVER=" + servidor + ";" + "DATABASE=" + basededatos + ";" + "USER=" + usuario + ";" + "PASSWORD=" + contraseña + ";";
            conexion = new MySqlConnection(Conexionstring);
            try
            {
                //conexion.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error en la conexión" + Convert.ToString(ex));
            }
        }



        public void cargarLibros()
        {
            List<int> totalIdLibros = obtenerIdLibros();
            foreach (int id in totalIdLibros)
            {
                gestorLibros.crearLibro(obtenerNombreLibro(id), obtenerTemaLibro(id), obtenerEditorialLibro(id), obtenerPrecioLibro(id), obtenerCantidadLibro(id), obtenerFechaIngreso(id));
            }
        }

        public List<int> obtenerIdLibros()
        {
            List<int> but = new List<int>();
            String Query = "SELECT `idlibros` FROM `libros`";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                but.Add(rdr.GetInt32(0));
            }
            conexion.Close();
            return but;
        }

        public void crearLibro(String nombre, String tema, String editorial, int precio, int cantidad, DateTime fechaIngreso)
        {
            String Query = "INSERT INTO `cookbooks`.`libros` (`idlibros`, `nombre`, `tema`, `editorial`, `precio`, `cantidad`, `fecha_ingreso`) VALUES (null,'" + nombre + "','" + tema + "','" + editorial + "','" + precio + "','" + cantidad + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "')";
            this.ejecutarQuery(Query);    
        }


        public DateTime obtenerFechaIngreso(int id_Libro)
        {
            String Query = "SELECT `fecha_ingreso` FROM `libros` WHERE idlibros= " + id_Libro + ";";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                fechaIngreso = rdr.GetDateTime(0);
            }
            conexion.Close();
            return fechaIngreso;
        }

        public string obtenerNombreLibro(int id_Libro)
        {
            String Query = "SELECT `nombre` FROM `libros` WHERE idlibros= " + id_Libro + ";";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                nombreLibro = rdr.GetString(0);
            }
            conexion.Close();
            return nombreLibro;
        }

        public string obtenerTemaLibro(int id_Libro)
        {
            String Query = "SELECT `tema` FROM `libros` WHERE idlibros= " + id_Libro + ";";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                temaLibro = rdr.GetString(0);
            }
            conexion.Close();
            return temaLibro;
        }

        public string obtenerEditorialLibro(int id_Libro)
        {
            String Query = "SELECT `editorial` FROM `libros` WHERE idlibros= " + id_Libro + ";";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                editorialLibro = rdr.GetString(0);
            }
            conexion.Close();
            return editorialLibro;
        }


        public int obtenerPrecioLibro(int id_Libro)
        {
            String Query = "SELECT `precio` FROM `libros` WHERE idlibros= " + id_Libro + ";";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                precioLibro = rdr.GetInt32(0);
            }
            conexion.Close();
            return precioLibro;
        }

        public int obtenerCantidadLibro(int id_Libro)
        {
            String Query = "SELECT `cantidad` FROM `libros` WHERE idlibros= " + id_Libro + ";";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cantidadLibro = rdr.GetInt32(0);
            }
            conexion.Close();
            return cantidadLibro;
        }

        public int obteneridLibro(String nombre)
        {
            String Query = "SELECT `idlibros` FROM `libros` WHERE nombre= " + nombre + ";";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                idLibros = rdr.GetInt32(0);
            }
            conexion.Close();
            return idLibros;
        }


        public int generaridlibro()
        {
            String Query_last_id = "SELECT `idlibros` FROM `libros` ORDER BY `idlibros` DESC LIMIT 1";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query_last_id, conexion);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ultimoIdLibro = rdr.GetInt32(0);
            }
            ultimoIdLibro = ultimoIdLibro + 1;
            conexion.Close();
            return ultimoIdLibro;
        }


        public void eliminarLibro(String nombre)
        {
            String Query = "DELETE FROM `cookbooks`.`libros` WHERE nombre=" + nombre + ";";
            this.ejecutarQuery(Query);
        }

        /*public void reservarButaca(int id_butaca, int reserva_id, int id_sala)
        {
            String Query = "INSERT INTO `sistema_cine`.`reserva_detalle`( `butaca_id`,`reserva_id`, `sala_id`) VALUES (" + id_butaca + "," + reserva_id + "," + id_sala + ")";
            this.ejecutarQuery(Query);

        }

        public void desreservarButaca(int id_butaca, int id_reserva)
        {
            String Query = "DELETE FROM `sistema_cine`.`reserva_detalle` WHERE `butaca_id` = " + id_butaca + ";";
            this.ejecutarQuery(Query);
            String Query2 = "UPDATE `sistema_cine`.`reservas` SET `estado`= 'cancelado' WHERE `reserva_id` =" + id_reserva + ";";
            this.ejecutarQuery(Query2);

        }

        public string obtenerSala(int idsala)
        {
            String Query = "SELECT `nombre` FROM `sistema_cine`.`sala` WHERE sala_id= " + idsala + ";";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                salanombre = rdr.GetString(0);
            }
            conexion.Close();
            return salanombre;
        }

        /*
         * FALTA ID PELICULA, SALA, CLIENTE 
         * *
        public void generarReserva(string codigo)
        {
            String Query_reserva = "INSERT INTO sistema_cine.Reservas(`cod_reserva`,`estado`)VALUES(" + "'" + codigo + "'" + ",'activo')";
            this.ejecutarQuery(Query_reserva);


        }
        public int obteneridReserva()
        {
            String Query_last_id = "SELECT `reserva_id` FROM `sistema_cine`.`Reservas` ORDER BY `reserva_id` DESC LIMIT 1";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query_last_id, conexion);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                last_id = rdr.GetInt32(0);
            }
            last_id = last_id + 1;
            conexion.Close();
            return last_id;


        }
        public int obteneridcodigoreserva(string codigoreserva)
        {
            String Query = "SELECT `reserva_id` FROM `sistema_cine`.`reservas` WHERE `cod_reserva`=" + "'" + codigoreserva + "'" + ";";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                id_res = rdr.GetInt32(0);
            }
            conexion.Close();
            return id_res;
        }
        public List<int> obtenerbutacas(int idreserva)
        {
            List<int> but = new List<int>();
            String Query = "SELECT `butaca_id` FROM `sistema_cine`.`reserva_detalle` WHERE `reserva_id`=" + idreserva + ";";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                but.Add(rdr.GetInt32(0));
            }
            conexion.Close();
            return but;
        }*/


        public void ejecutarQuery(String Query)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }


    }
}
