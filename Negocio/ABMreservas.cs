using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ABMreservas
    {
        DatosReserva dr = new DatosReserva();
        public ABMreservas() { }

        public List<Reserva> consultarReservas()
        {
            return dr.ObtenerReservas();
        }
    }
}
