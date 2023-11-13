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
        public ABMInstalaciones() { }
        DatosInstalacion di = new DatosInstalacion();

        public List<Instalacion> obtenerTodasInstalaciones()
        {
            return di.obtenerTodasInstalaciones();
        }

        public Instalacion obtenerInstalacionPorId(int id)
        {
            return di.obtenerInstalacionXId(id);
        }
        public List<Instalacion> consultarInstalaciones(string act)
        {
            return di.obtenerInstalaciones(act);
        }
        public Instalacion obtenerXDescripcion(string desc)
        {
            return di.obtenerInstalacionesXDescripcion(desc);
        }
        public int add(Instalacion instalacion)
        {
            return di.addInstalacion(instalacion);
        }

        public void update(Instalacion instalacion)
        {
            di.updateInstalacion(instalacion);
        }

        public void delete(int id)
        {
            di.deleteInstalacion(id);
        }
    }
}
