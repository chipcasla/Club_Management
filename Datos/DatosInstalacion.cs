using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosInstalacion
    {
        public DatosInstalacion() { }

        public List<Instalacion> obtenerTodasInstalaciones()
        {
            List<Instalacion> instalaciones = new List<Instalacion>();

            SqlConnection connection = Conexion.openConection();
            string query = "SELECT idInstalacion, ins.descripcion as 'descIns', ins.idActividad, act.descripcion as 'descAct' FROM instalaciones ins inner join actividades act on ins.idActividad = act.idActividad;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Instalacion instalacion = new Instalacion
                        (
                            int.Parse(reader["idInstalacion"].ToString()),
                            reader["descIns"].ToString(),
                            new Actividad(
                                int.Parse(reader["idActividad"].ToString()),
                                reader["descAct"].ToString(),
                                0
                            )
                        );
                        instalaciones.Add(instalacion);
                    }
                }
            }

            Conexion.closeConnection(connection);

            return instalaciones;
        }
        public List<Instalacion> obtenerInstalaciones(string act)
        {
            List<Instalacion> instalaciones = new List<Instalacion>();

            SqlConnection connection = Conexion.openConection();
            string query = "select idInstalacion, ins.descripcion, ins.idActividad from instalaciones ins inner join actividades act on ins.idActividad = act.idActividad where act.descripcion = @desAct;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@desAct", act);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Instalacion ins = new Instalacion
                        (
                            int.Parse(reader["idInstalacion"].ToString()),
                            reader["descripcion"].ToString(),
                            new Actividad 
                            (
                                int.Parse(reader["idActividad"].ToString()),
                                act,
                                0                               
                            )
                        );
                        instalaciones.Add(ins);
                    }
                }
            }

            Conexion.closeConnection(connection);

            return instalaciones;
        }
        public Instalacion obtenerInstalacionesXDescripcion(string descIns)
        {
            
            SqlConnection connection = Conexion.openConection();
            string query = "select ins.idInstalacion, ins.idActividad, act.descripcion from instalaciones ins left join actividades act on ins.idActividad = act.idActividad where ins.descripcion = @descIns;";

            Instalacion ins = null;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@descIns", descIns);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        ins = new Instalacion(
                            
                            int.Parse(reader["idInstalacion"].ToString()),
                            descIns,
                            new Actividad
                            (
                                int.Parse(reader["idActividad"].ToString()),
                                reader["descripcion"].ToString(),
                                0
                            )
                        );
                        
                    }
                }
            }

            Conexion.closeConnection(connection);

            return ins;
        }

        public Instalacion obtenerInstalacionXId(int id)
        {

            SqlConnection connection = Conexion.openConection();
            string query = "select ins.descripcion as 'descIns', ins.idActividad, act.descripcion from instalaciones ins left join actividades act on ins.idActividad = act.idActividad where ins.idInstalacion = @idIns;";

            Instalacion ins = null;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idIns", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ins = new Instalacion(

                            id,
                            reader["descIns"].ToString(),
                            new Actividad
                            (
                                int.Parse(reader["idActividad"].ToString()),
                                reader["descripcion"].ToString(),
                                0
                            )
                        );

                    }
                }
            }

            Conexion.closeConnection(connection);

            return ins;
        }

        public int addInstalacion(Instalacion instalacion)
        {
            SqlConnection connection = null;
            try
            {
                connection = Conexion.openConection();

                // Consulta SQL para buscar la persona por DNI y contraseña
                string query = "INSERT INTO instalaciones VALUES (@Descripcion, @IdActividad)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Descripcion", instalacion.getDescripcion());
                    command.Parameters.AddWithValue("@IdActividad", instalacion.Actividad.getId());                    

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

        public void updateInstalacion(Instalacion instalacion)
        {
            SqlConnection connection = null;
            try
            {

                connection = Conexion.openConection();

                // Consulta SQL para buscar la persona por DNI y contraseña
                string query = "UPDATE instalaciones SET descripcion = @Descripcion, idActividad = @IdActividad WHERE idInstalacion = @IdIns";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Descripcion", instalacion.getDescripcion());
                    command.Parameters.AddWithValue("@IdActividad", instalacion.Actividad.getId());
                    command.Parameters.AddWithValue("@IdIns", instalacion.getId());

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

        public void deleteInstalacion(int id)
        {
            using (SqlConnection connection = Conexion.openConection())
            {
                string query = "DELETE FROM instalaciones WHERE idInstalacion = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
