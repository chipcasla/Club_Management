using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class ABMcuotas
    {
        DatosCuotas dc = new DatosCuotas();
        public ABMcuotas() { }
        public List<Cuota> consultarCuotas(Persona p)
        {
            return dc.obtenerCuotasSocios(p.getDni());
        }
    }
}
