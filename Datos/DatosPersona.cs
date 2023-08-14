using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosPersona
    {
        public DatosPersona() { }   
        public Persona getPersona(string dni, string password)
        {
            Persona personaEncontrada = null;

            //Abrir conexion

            SqlConnection connection = Conexion.openConection();

            // Consulta SQL para buscar la persona por DNI y contraseña
            string query = "SELECT * FROM personas p WHERE p.dni=@DNI and p.password=@password";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DNI", dni);
                command.Parameters.AddWithValue("@password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();
                        int numDoc = Int32.Parse( reader["dni"].ToString());
                        string pass = reader["password"].ToString();
                        string mail = reader["email"].ToString();

                        personaEncontrada = new Persona( numDoc,  nombre,  apellido,  mail,  pass);

                    }
                }
            }

            return personaEncontrada;
        }
    }
}