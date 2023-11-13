using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Datos
{
    internal class Conexion
    {

        public static SqlConnection connection = null;
        public static SqlConnection openConection()
        {
            string connectionString = "Data Source=DESKTOP-JULIANB\\SQLSERVEREXPRESS;Initial Catalog=db_club;Integrated Security=True;";
           
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                Console.WriteLine("Conexión exitosa a la base de datos.");
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open(); // Abre la conexión si está cerrada
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }

            return connection;
        }

        public static void closeConnection(SqlConnection connection)
        {
            try
            {
                connection.Close();
                Console.WriteLine("Conexión cerrada.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }

    }
}
