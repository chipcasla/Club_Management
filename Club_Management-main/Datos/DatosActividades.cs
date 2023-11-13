using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosActividades
    {
        public DatosActividades() { }

        public List<Actividad> obtenerActividades()
        {
            List<Actividad> actividades = new List<Actividad>();

            SqlConnection connection = Conexion.openConection();
            string query = "SELECT idActividad, descripcion FROM actividades;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Actividad a = new Actividad
                        (
                            int.Parse(reader["idActividad"].ToString()),
                            reader["descripcion"].ToString(),
                            0
                        );
                        actividades.Add(a);
                    }
                }
            }

            Conexion.closeConnection(connection);

            return actividades;
        }

        public Actividad obtenerActividadXId(int id)
        {

            SqlConnection connection = Conexion.openConection();
            string query = "select act.idActividad, act.descripcion from actividades act where act.idActividad = @idAct;";

            Actividad act = null;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idAct", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        act = new Actividad
                            (
                                int.Parse(reader["idActividad"].ToString()),
                                reader["descripcion"].ToString(),
                                0
                            );
                    }
                }
            }

            Conexion.closeConnection(connection);

            return act;
        }

        public int addActividad(Actividad actividad)
        {
            SqlConnection connection = null;
            try
            {
                connection = Conexion.openConection();

                // Consulta SQL para buscar la persona por DNI y contraseña
                string query = "INSERT INTO actividades VALUES (@Descripcion, @Costo)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Descripcion", actividad.getDescripcion());
                    command.Parameters.AddWithValue("@Costo", actividad.getCosto());

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected;
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

        public void updateActividad(Actividad actividad)
        {
            SqlConnection connection = null;
            try
            {
                connection = Conexion.openConection();

                // Consulta SQL para actualizar actividad
                string query = "UPDATE actividades SET descripcion = @Descripcion, costo = @Costo WHERE idActividad = @IdAct";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Descripcion", actividad.getDescripcion());
                    command.Parameters.AddWithValue("@Costo", actividad.getCosto());
                    command.Parameters.AddWithValue("@IdAct", actividad.getId());

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

        public void deleteActividad(int id)
        {
            using (SqlConnection connection = Conexion.openConection())
            {
                string query = "DELETE FROM actividades WHERE idActividad = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
