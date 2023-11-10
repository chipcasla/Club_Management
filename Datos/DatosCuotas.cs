using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosCuotas
    { 
        public  DatosCuotas() { }
        public List<Cuota> obtenerCuotasSocios(int dni)
        {
            List<Cuota> cuotas = new List<Cuota>();
            SqlConnection connection = Conexion.openConection();
            using (SqlCommand command = new SqlCommand("SELECT idSocio,anio, mes, pagado, monto FROM Cuotas WHERE idSocio = @dni", connection))
            {
                command.Parameters.AddWithValue("@dni", dni);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cuota cuota = new Cuota
                        (
                            idsocio: reader.GetInt32(0),
                            anio: reader.GetInt32(1),
                            mes: reader.GetInt32(2),
                            pagado: reader.GetBoolean(3),
                            monto: reader.GetDecimal(4)
                        );
                        cuotas.Add(cuota);
                    }
                }
            }
            Conexion.closeConnection(connection);

            return cuotas;
        }
    }
    
}

