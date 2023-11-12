using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosEntrenamiento
    {
        public DatosEntrenamiento() { }

        public bool ExisteEntrenamientoEnFechaYHora(int dia, TimeOnly hora, Instalacion instalacion)
        {
            using (SqlConnection connection = Conexion.openConection())
            {
                string query = "SELECT COUNT(*) FROM entrenamientos " +
                               "WHERE dia = @Dia AND horaDesde <= @Hora AND horaHasta > @Hora " +
                               "AND instalacionId = @InstalacionId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Dia", dia);
                    command.Parameters.AddWithValue("@Hora", hora);
                    command.Parameters.AddWithValue("@InstalacionId", instalacion.getId());

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void CrearEntrenamiento(Entrenamiento entrenamiento)
        {
            try
            {
                using (SqlConnection connection = Conexion.openConection())
                {
                    string query = "INSERT INTO entrenamientos (horaDesde, horaHasta, dia, idProfesor, idInstalacion) " +
                                   "VALUES (@HoraDesde, @HoraHasta, @Dia, @ProfesorId, @InstalacionId)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HoraDesde", entrenamiento.HoraDesde);
                        command.Parameters.AddWithValue("@HoraHasta", entrenamiento.HoraHasta);
                        command.Parameters.AddWithValue("@Dia", entrenamiento.Dia);
                        command.Parameters.AddWithValue("@ProfesorId", entrenamiento.Profesor.getDni());
                        command.Parameters.AddWithValue("@InstalacionId", entrenamiento.Instalacion.getId());

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public List<Entrenamiento> ConsultarEntrenamientosPorInstalacionDiaYHora(int idInstalacion, int dia, TimeOnly hora)
        {
            List<Entrenamiento> entrenamientos = new List<Entrenamiento>();

            using (SqlConnection connection = Conexion.openConection())
            {

                string query = "SELECT * FROM entrenamientos " +
                               "WHERE dia = @Dia AND horaDesde <= @Hora AND horaHasta > @Hora AND instalacionId = @InstalacionId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Dia", dia);
                    command.Parameters.AddWithValue("@Hora", hora);
                    command.Parameters.AddWithValue("@InstalacionId", idInstalacion);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Entrenamiento entrenamiento = new Entrenamiento
                            (
                                (int)reader["IdEntrenamiento"],
                                (TimeOnly)reader["horaDesde"],
                                (TimeOnly)reader["horaHasta"],
                                (int)reader["dia"],
                                new DatosInstalacion().obtenerInstalacionXId((int)reader["instalacionId"]),                              
                                (Profesor)new DatosPersona().getPersonaByDNI(reader["profesorId"].ToString())
                            );

                            entrenamientos.Add(entrenamiento);
                        }
                    }
                }
            }

            return entrenamientos;
        }

        public List<Entrenamiento> ConsultarEntrenamientosProfesor(string dni)
        {
            List<Entrenamiento> entrenamientos = new List<Entrenamiento>();

            using (SqlConnection connection = Conexion.openConection())
            {

                string query = "SELECT * FROM entrenamientos " +
                               "WHERE profesorId = @ProfesorId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProfesorId", dni);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Entrenamiento entrenamiento = new Entrenamiento
                            (
                                (int)reader["idEntrenamiento"],
                                (TimeOnly)reader["horaDesde"],
                                (TimeOnly)reader["horaHasta"],
                                (int)reader["dia"],
                                new DatosInstalacion().obtenerInstalacionXId((int)reader["instalacionId"]),
                                (Profesor)new DatosPersona().getPersonaByDNI(reader["profesorId"].ToString())
                            );

                            entrenamientos.Add(entrenamiento);
                        }
                    }
                }
            }

            return entrenamientos;
        }
    }
}

