using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Reserva
    {
        public Reserva(int id, string estado, DateTime turno, TimeOnly hora, Persona persona , Instalacion instalacion)
        {
            Id = id;
            Estado = estado;
            Turno = turno;
            Persona = persona;
            Instalacion = instalacion;
            Hora = hora;
        }
        public Reserva() { }
        public int Id { get; set; }
        public string Estado { get; set; }

        public DateTime Turno { get; set; }

        public TimeOnly Hora { get; set; }
        public Persona Persona { get; set; }
        public Instalacion Instalacion { get; set; }
    }
}