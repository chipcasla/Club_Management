using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonaCuota
    {
        int dni;
        String nombre;
        String apellido;
        String mail;
        int cuotasAsignadas;
        int debe;
        decimal montoDeuda;

        public PersonaCuota(int dni, string nombre, string apellido, string mail, int cuotasAsignadas, int debe, decimal montoDeuda)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.cuotasAsignadas = cuotasAsignadas;
            this.debe = debe;
            this.montoDeuda = montoDeuda;
        }
        public int getDni()
        {
            return this.dni;
        }

        public String getNombre()
        {
            return this.nombre;
        }
        public String getApellido()
        {
            return this.apellido;
        }
        public String getMail()
        {
            return this.mail;
        }
        public int getDebe()
        {
            return this.debe;
        }

        public decimal getMonto()
        {
            return this.montoDeuda;
        }
        public int getCuotasAsignadas()
        {
            return this.cuotasAsignadas;
        }
        
    }
}
