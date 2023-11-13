using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Entrenamiento
    {
        public int IdEntrenamiento { get; set; }
        public TimeOnly HoraDesde { get; set; }
        public TimeOnly HoraHasta { get; set; }
        public int Dia { get; set; }

        public Instalacion Instalacion { get; set; }
        public Profesor Profesor { get; set; }

        public Entrenamiento(int idEntrenamiento, TimeOnly horaDesde, TimeOnly horaHasta, int dia,Instalacion instalacion, Profesor profesor)
        {
            IdEntrenamiento = idEntrenamiento;
            HoraDesde = horaDesde;
            HoraHasta = horaHasta;
            Dia = dia;
            Instalacion = instalacion;
            Profesor = profesor;
        }
    }
}