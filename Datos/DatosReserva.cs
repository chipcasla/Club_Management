using Entidades;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Resources;

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
            string query = "SELECT idReservas, estado, fecha, hora , ins.idActividad , act.descripcion actDescripcion, act.costo, ins.idInstalacion, ins.descripcion insDescripcion, per.dni FROM reservas res INNER JOIN instalaciones ins on ins.idInstalacion = res.idInstalacion INNER JOIN personas per on per.dni = res.dni INNER JOIN actividades act on ins.idActividad = act.idActividad;";

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
                            (DateTime)reader["fecha"], // Aquí asignamos directamente el DateTime
                            TimeOnly.FromTimeSpan(reader.GetTimeSpan(reader.GetOrdinal("hora"))),
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

        public List<Reserva> ObtenerReservaCliente(int dni)
        {
            List<Reserva> reservas = new List<Reserva>();

            SqlConnection connection = Conexion.openConection();
            string query = "SELECT idReservas, estado, fecha, hora , ins.idActividad , act.descripcion actDescripcion, act.costo, ins.idInstalacion, ins.descripcion insDescripcion, per.dni FROM reservas res INNER JOIN instalaciones ins on ins.idInstalacion = res.idInstalacion INNER JOIN personas per on per.dni = res.dni INNER JOIN actividades act on ins.idActividad = act.idActividad WHERE per.dni = @dni ;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@dni", dni);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DatosPersona datosPersona = new DatosPersona();
                        Reserva reserva = new Reserva
                        (
                            int.Parse(reader["idReservas"].ToString()),
                            reader["estado"].ToString(),
                            (DateTime)reader["fecha"],
                            TimeOnly.FromTimeSpan(reader.GetTimeSpan(reader.GetOrdinal("hora"))),
                            //(TimeOnly)reader["hora"],
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
        public List<Reserva> ObtenerReservasDisponibles(string descInstalacion, DateTime fecha )
        {
            List<Reserva> reservas = new List<Reserva>();

            SqlConnection connection = Conexion.openConection();
            string query = "select idReservas, res.estado,res.idInstalacion,res.dni, res.fecha, res.hora, idActividad from reservas res inner join instalaciones ins on res.idInstalacion = ins.idInstalacion where estado = 'PENDIENTE' and descripcion = @descInstalacion and fecha >= @fechaMin and fecha <= @fechaMax ;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@descInstalacion", descInstalacion);
                command.Parameters.AddWithValue("@fechaMin", fecha.Date);
                command.Parameters.AddWithValue("@fechaMax", fecha.Date.AddDays(1).AddTicks(-1));
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DatosPersona datosPersona = new DatosPersona();
                        Reserva reserva = new Reserva
                        (
                            int.Parse(reader["idReservas"].ToString()),
                            reader["estado"].ToString(),
                            (DateTime)reader["fecha"],
                            TimeOnly.FromTimeSpan(reader.GetTimeSpan(reader.GetOrdinal("hora"))),
                            //(TimeOnly)reader["hora"],
                            datosPersona.getPersonaByDNI(reader["dni"].ToString()),
                            new Instalacion
                            (
                                int.Parse(reader["idInstalacion"].ToString()),
                                descInstalacion,
                                new Actividad
                                (
                                    int.Parse(reader["idActividad"].ToString()),
                                    "",
                                    0
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

        public List<Reserva> obtenerReservasPorFecha(DateTime fecha)
        {
            List<Reserva> reservas = new List<Reserva>();

            SqlConnection connection = Conexion.openConection();
            string query = "select idReservas, res.estado,res.idInstalacion, ins.descripcion, res.dni, res.fecha, res.hora, idActividad from reservas res inner join instalaciones ins on res.idInstalacion = ins.idInstalacion where estado = 'PENDIENTE' and fecha = @fecha;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@fecha", fecha.Date);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DatosPersona datosPersona = new DatosPersona();
                        Reserva reserva = new Reserva
                        (
                            int.Parse(reader["idReservas"].ToString()),
                            reader["estado"].ToString(),
                            (DateTime)reader["fecha"],
                            TimeOnly.FromTimeSpan(reader.GetTimeSpan(reader.GetOrdinal("hora"))),
                            //(TimeOnly)reader["hora"],
                            datosPersona.getPersonaByDNI(reader["dni"].ToString()),
                            new DatosInstalacion().obtenerInstalacionXId(int.Parse(reader["idInstalacion"].ToString()))
                        );
                        reservas.Add(reserva);
                    }
                }
            }

            Conexion.closeConnection(connection);

            return reservas;
        }

        public int addReserva(Reserva reserva)
        {
            SqlConnection connection = null;
            try
            {
              
                connection = Conexion.openConection();

                string query = "DECLARE @nuevoIdReservas INT SELECT @nuevoIdReservas = ISNULL(MAX(idReservas), 0) + 1 FROM reservas INSERT INTO reservas (idReservas, estado, idInstalacion, dni, fecha, hora) VALUES (@nuevoIdReservas, 'Pendiente', @idInstalacion, @dni, @fecha, @hora);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idInstalacion", reserva.Instalacion.getId());
                    command.Parameters.AddWithValue("@dni", reserva.Persona.getDni());
                    command.Parameters.AddWithValue("@fecha", reserva.Turno);
                    command.Parameters.AddWithValue("@hora", reserva.Hora.ToTimeSpan());
                    

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción ArgumentException: {ex.Message}");
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

        public void cancelarReserva(Reserva reserva)
        {
            SqlConnection connection = null;
            try
            {
                connection = Conexion.openConection();
                // Consulta SQL para cambiar el estado de reserva a cancelada
                string query = "UPDATE reservas SET estado = 'Cancelada' WHERE idReservas = @IdReserva";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdReserva", reserva.Id);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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
