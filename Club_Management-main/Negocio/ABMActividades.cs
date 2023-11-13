using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ABMActividades
    {
        public ABMActividades() { }
        DatosActividades da = new DatosActividades();

        public List<Actividad> obtenerTodasActividades()
        {
            return da.obtenerActividades();
        }

        public Actividad obtenerActividadPorId(int id)
        {
            return da.obtenerActividadXId(id);
        }

        public int add(Actividad actividad)
        {
            return da.addActividad(actividad);
        }

        public void update(Actividad actividad)
        {
            da.updateActividad(actividad);
        }

        public void delete(int id)
        {
            da.deleteActividad(id);
        }
    }
}
