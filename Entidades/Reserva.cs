using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Reserva
    {
        public Reserva(int id, string estado, DateTime turno, Persona persona , Instalacion instalacion)
        {
            Id = id;
            Estado = estado;
            Turno = turno;
            Persona = persona;
            Instalacion = instalacion;
        }
        public int Id { get; set; }
        public string Estado { get; set; }

        public DateTime Turno { get; set; }


        public Persona Persona {
            get => default;
            set {
            }
        }

        public Instalacion Instalacion {
            get => default;
            set {
            }
        }
    }
}