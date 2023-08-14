using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Datos
{
    internal class Conexion
    {

        public static SqlConnection connection = null;
        public static SqlConnection openConection()
        {
            string connectionString = "Data Source=MS-10\\SQLEXPRESS;Initial Catalog=db_club;User ID=net;Password=net";

           
            try
            {
                if(connection == null)
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }

            return connection;
        }

        static void CloseConnection(SqlConnection connection)
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
