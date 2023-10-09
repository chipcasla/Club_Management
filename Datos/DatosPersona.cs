using Entidades;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Net;
using System.Reflection.PortableExecutable;

namespace Datos
{
    public class DatosPersona
    {
        public DatosPersona()
        {

        }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();

            SqlConnection connection = Conexion.openConection();
            string query = "SELECT dni, nombre, apellido, email FROM personas;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Persona persona = new Persona
                        (
                            int.Parse(reader["dni"].ToString()),
                            reader["nombre"].ToString(),
                            reader["apellido"].ToString(),
                            reader["email"].ToString(),
                            ""
                        );
                        personas.Add(persona);
                    }
                }           
            }

            Conexion.closeConnection(connection);

            return personas;
        }

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
                    try
                    {
                        if (reader.Read())
                        {
                            string nombre = reader["nombre"].ToString();
                            string apellido = reader["apellido"].ToString();
                            int numDoc = int.Parse(reader["dni"].ToString());
                            string pass = reader["password"].ToString();
                            string mail = reader["email"].ToString();

                            personaEncontrada = new Persona(numDoc, nombre, apellido, mail, pass);
                            System.Diagnostics.Debug.WriteLine("BIEN");
                        }
                    }
                    catch 
                    { 
                        Conexion.closeConnection(connection);
                        System.Diagnostics.Debug.WriteLine("MAL");
                        return null;
                    }
                }
            }
            Conexion.closeConnection(connection);

            return personaEncontrada;
        }

        public Persona getPersonaByDNI(string dni)
        {
            Persona personaEncontrada = null;
            //Abrir conexion

            SqlConnection connection = Conexion.openConection();

            // Consulta SQL para buscar la persona por DNI y contraseña
            string query = "SELECT * FROM personas p WHERE p.dni=@DNI";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DNI", dni);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.Read())
                        {
                            string nombre = reader["nombre"].ToString();
                            string apellido = reader["apellido"].ToString();
                            int numDoc = int.Parse(reader["dni"].ToString());
                            string pass = reader["password"].ToString();
                            string mail = reader["email"].ToString();

                            personaEncontrada = new Persona(numDoc, nombre, apellido, mail, "");
                            System.Diagnostics.Debug.WriteLine("BIEN");
                        }
                    }
                    catch
                    {
                        Conexion.closeConnection(connection);
                        System.Diagnostics.Debug.WriteLine("MAL");
                        return null;
                    }
                }
            }
            Conexion.closeConnection(connection);

            return personaEncontrada;
        }

        public int validarDuplicado(int dni)
        {
            List<Persona> personas = ObtenerPersonas();
            foreach (Persona p in personas) 
            {
                if(p.getDni() == dni)
                {
                    return 2;
                }
            }
            return 0;
        }

        public int addPersona(Persona persona)
        {
            SqlConnection connection = null;
            try
            {
                if(validarDuplicado(persona.getDni()) == 2)
                {
                    return 2;
                }
                else
                {
                    connection = Conexion.openConection();

                    // Consulta SQL para buscar la persona por DNI y contraseña
                    string query = "INSERT INTO personas VALUES (@dni, @nombre, @apellido, @mail, @password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@dni", persona.getDni());
                        command.Parameters.AddWithValue("@nombre", persona.getNombre());
                        command.Parameters.AddWithValue("@apellido", persona.getApellido());
                        command.Parameters.AddWithValue("@mail", persona.getMail());
                        command.Parameters.AddWithValue("@password", persona.getPassword());

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (connection != null) 
                {
                    Conexion.closeConnection(connection);                    
                }
            }
        }
    }

}