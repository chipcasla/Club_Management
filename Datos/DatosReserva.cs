using Entidades;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Net;
using System.Runtime.Intrinsics.Arm;

namespace Datos
{
    public class DatosReserva
    {
        public DatosReserva()
        {

        }

        public List<Reserva> ObtenerReservas()
        {
            List<Reserva> reservas = new List<Reserva>();

            SqlConnection connection = Conexion.openConection();
            string query = "SELECT idReservas, estado, fechaHora , ins.idActividad , act.descripcion actDescripcion, act.costo, ins.idInstalacion, ins.descripcion insDescripcion, per.dni FROM reservas res INNER JOIN instalaciones ins on ins.idInstalacion = res.idInstalacion INNER JOIN personas per on per.dni = res.dni INNER JOIN actividades act on ins.idActividad = act.idActividad;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DatosPersona datosPersona = new DatosPersona();
                        Reserva reserva = new Reserva
                        (
                            int.Parse(reader["idReservas"].ToString()),
                            reader["estado"].ToString(),
                            (DateTime)reader["fechaHora"], // Aquí asignamos directamente el DateTime
                            datosPersona.getPersonaByDNI(reader["dni"].ToString()),
                            new Instalacion
                            (
                                int.Parse(reader["idInstalacion"].ToString()),
                                reader["insDescripcion"].ToString(),
                                new Actividad
                                (
                                    int.Parse(reader["idActividad"].ToString()),
                                    reader["actDescripcion"].ToString(),
                                    float.Parse(reader["costo"].ToString())
                                )
                            )
                        );
                        reservas.Add(reserva);
                    }
                }
            }

            Conexion.closeConnection(connection);

            return reservas;
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

    }

}
