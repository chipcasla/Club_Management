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
    }
}
