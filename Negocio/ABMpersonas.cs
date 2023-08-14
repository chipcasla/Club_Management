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
        public Persona validarInicio(string dni, string pass)
        {
            DatosPersona dp = new DatosPersona();
            return dp.getPersona(dni, pass);
        }
    }
}
