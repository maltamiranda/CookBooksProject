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
        String contraseña = "1234";
        MySqlDataReader rdr = null;
        int precioLibro;
        int cantidadLibro;
        int idLibros;
        int ultimoIdLibro;
        int idAutor;
        String nombreLibro;
        String temaLibro;
        String editorialLibro;
        DateTime fechaIngreso;
        GestorLibros gestorLibros;
        GestorAutores gestorAutores;

        public DBManager(GestorLibros gestorLibros, GestorAutores gestorAutores) 
        {
           this.gestorLibros = gestorLibros;
            this.gestorAutores = gestorAutores;
        }



        public void autorLibro(int idAutor, int idLibro) {

            String Query = "INSERT INTO `cookbooks`.`libro_autor` (`idautor`, `idlibro`, `idlibro_autor`) VALUES ("+idAutor+","+idLibro+",null)" ;
            this.ejecutarQuery(Query);
        
        }

        public DBManager(GestorAutores gestorAutores)
        {
            this.gestorAutores = gestorAutores;
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
                gestorLibros.crearLibro(obtenerNombreLibro(id), obtenerTemaLibro(id), new Autor("","","",0), obtenerEditorialLibro(id), obtenerPrecioLibro(id), obtenerCantidadLibro(id), obtenerFechaIngreso(id));
            }
        }

        public void cargarAutores()
        {
            List<int> totalIdAutores = obtenerIdAutores();
            foreach (int id in totalIdAutores)
            {
                gestorAutores.crearAutor(obtenerNombreAutor(id), obtenerApellidoAutor(id), obtenerNacionalidadAutor(id),id);
            }
        }

        public string obtenerNombreAutor(int id_Autor)
        {
            String Query = "SELECT `nombre` FROM `autores` WHERE idautor= " + id_Autor + ";";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            String nombreAutor="";
            while (rdr.Read())
            {
                nombreAutor = rdr.GetString(0);
            }
            conexion.Close();
            return nombreAutor;
        }

        public string obtenerApellidoAutor(int id_Autor)
        {
            String Query = "SELECT `apellido` FROM `autores` WHERE idautor= " + id_Autor + ";";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            String apellidoAutor = "";
            while (rdr.Read())
            {
                apellidoAutor = rdr.GetString(0);
            }
            conexion.Close();
            return apellidoAutor;
        }

        public string obtenerNacionalidadAutor(int id_Autor)
        {
            String Query = "SELECT `nacionalidad` FROM `autores` WHERE idautor= " + id_Autor + ";";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            String nacionalidadAutor = "";
            while (rdr.Read())
            {
                nacionalidadAutor = rdr.GetString(0);
            }
            conexion.Close();
            return nacionalidadAutor;
        }




        public List<int> obtenerIdAutores()
        {
            List<int> but = new List<int>();
            String Query = "SELECT `idautor` FROM `autores`";
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


        public int getProximoIdAutor() {
            String Query = "Select max(id) from autores";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            int proximoId = rdr.GetInt32(0)+1;
            return proximoId;


        
        }

        public void crearAutor(String nombre, String apellido, String nacionalidad)
        {
            String Query = "INSERT INTO `cookbooks`.`autores` (`nombre`, `apellido`, `nacionalidad`) VALUES ('" + nombre + "','" + apellido + "','" + nacionalidad  + "')";
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

        public int obteneridAutor(String nombre, String apellido, String nacionalidad)
        {
            String Query = "SELECT `idautor` FROM `autores` WHERE nombre= '" + nombre + 
                "' AND apellido='" + apellido + "' AND nacionalidad='" + nacionalidad + "';";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand(Query, conexion);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                idAutor = rdr.GetInt32(0);
            }
            conexion.Close();
            return idAutor;
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
            int id = obteneridLibro(nombre);
            String Query = "DELETE FROM `cookbooks`.`libros` WHERE idlibros=" + id + ";";
            String Query2 = "DELETE FROM `cookbooks`.`libro_autor` WHERE idLibro=" + id + ";";
            this.ejecutarQuery(Query2);
            this.ejecutarQuery(Query);
        }

        public void eliminarAutor(int id)
        {
            String Query = "DELETE FROM autores WHERE idautor=" + id + ";";
            this.ejecutarQuery(Query);
        }

        public void modificarLibro(String nombre, String tema, String editorial, int precio, int cantidad, int id)
        {
            String Query = "UPDATE `cookbooks`.`libros` SET `nombre`= '" + nombre + "',`tema`='" + tema + "',`editorial`='" + editorial + "',`precio`=" + precio + ",`cantidad`=" + cantidad + " WHERE `idlibros` =" + id + ";";
            this.ejecutarQuery(Query);

        }

        public void modificarAutor(String nombre, String apellido, String nacionalidad, int id)
        {
            String Query = "UPDATE autores SET nombre='" + nombre + "', apellido='" + apellido +
                "', nacionalidad='" + nacionalidad + "' WHERE idautor=" + id + ";";
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
