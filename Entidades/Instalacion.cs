using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Instalacion
    {
        private int idInstalacion;
        private string descripcion;

        public Instalacion(int iIdInstalacion, string iDescripcion, Actividad actividad)
        {
            idInstalacion = iIdInstalacion;
            descripcion = iDescripcion;
            Actividad = actividad;
        }
        public int getId()
        {
            return this.idInstalacion;
        }
        public string getDescripcion()
        {
            return this.descripcion;
        }
        public Actividad Actividad { get; set; }
    }
}