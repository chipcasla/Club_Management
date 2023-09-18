using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ABMpersonas
    {
        DatosPersona dp = new DatosPersona();
        public Persona validarInicio(string dni, string pass)
        {
            return dp.getPersona(dni, pass);
        }

        public int add(Persona persona)
        {
            return dp.addPersona(persona);
        }
    }
}
