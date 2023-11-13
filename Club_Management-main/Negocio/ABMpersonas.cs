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

        public List<Persona> obtenerSocios()
        {
            return dp.ObtenerSocios();
        }

        public List<Profesor> obtenerProfesores()
        {
            return dp.ObtenerEntrenadores();
        }
        public Persona validarInicio(string dni, string pass)
        {
            return dp.getPersona(dni, pass);
        }

        public int add(Persona persona)
        {
            return dp.addPersona(persona);
        }

        public int addProfesor(Profesor profesor)
        {
            return dp.addPersona(profesor);
        }

        public void update(Persona p)
        {
            dp.updatePersona(p);
        }

        public void delete(string dni)
        {
            dp.deletePersona(dni);
        }
        public List<PersonaCuota> obtenerSociosCuotas()
        {
            return dp.ObtenerSociosCuotas();
        }
        public int buscaPersona(int dni)
        {
            return dp.validarDuplicado(dni);
        }
    }
}
