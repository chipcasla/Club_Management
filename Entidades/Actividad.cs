using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Actividad
    {
        private int idActividad;
        private int descripcion;
        private int costo;

        public Entrenamiento Entrenamiento {
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