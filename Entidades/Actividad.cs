using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Actividad
    {
        private int idActividad;
        private string descripcion;
        private float costo;

        public Actividad(int iIdActividad, string iDescripcion, float iCosto)
        {
            idActividad = iIdActividad;
            descripcion = iDescripcion;
            costo = iCosto;
        }

        public Entrenamiento Entrenamiento {get; set; }
        public string getDescripcion()
        {
            return this.descripcion;
        }
    }
}