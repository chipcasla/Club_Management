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
    }
}
