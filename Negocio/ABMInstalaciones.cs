using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ABMInstalaciones
    {
        DatosInstalacion di = new DatosInstalacion();
        public List<Instalacion> consultarInstalaciones(string act)
        {
            return di.obtenerInstalaciones(act);
        }
    }
}
