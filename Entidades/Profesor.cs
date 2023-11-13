using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Profesor : Persona
    {
        public Profesor(int dni, string nombre, string apellido, string mail, string password, string rol): base(dni, nombre, apellido, mail, password, "entrenador")
        {
        }
    }
}