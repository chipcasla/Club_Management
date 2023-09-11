using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Entrenamiento
    {
        private int idEntrenamiento;
        private int horaDesde;

        private int horaHasta;
        private int dia;

        public Profesor Profesor {
            get => default;
            set {
            }
        }
    }
}