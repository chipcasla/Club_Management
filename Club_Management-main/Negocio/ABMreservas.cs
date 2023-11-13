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
        public List<Reserva> consultarReservaCliente(Persona p)
        {
            return dr.ObtenerReservaCliente(p.getDni()) ;
        }
        public List<Reserva> consultarReservasDisponibles(string descInst, DateTime fecha)
        {
            return dr.ObtenerReservasDisponibles(descInst,fecha);
        }

        public List<Reserva> reservasPorFecha(DateTime fecha)
        {
            return dr.obtenerReservasPorFecha(fecha);
        }
        public int  agregarReserva(Reserva reserva)
        {
            return dr.addReserva(reserva);
        }

        public void cancelarReserva(Reserva reserva)
        {
            dr.cancelarReserva(reserva);
        }
    }
}
