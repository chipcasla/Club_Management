using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        int dni;
        String nombre;
        String apellido;
        String mail;
        String password;
        String rol;

        public Persona()
        {
            this.dni = 1;
            this.nombre = "";
            this.apellido = "";
            this.mail = "";
            this.password = "";
            this.rol = "socio";
        }

        public Persona(int dni, string nombre, string apellido, string mail, string password, string rol)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.password = password;
            this.rol = "socio";
        }
        public string getRol()
        {
            return this.rol;
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

        public String getPassword()
        {
            return this.password;
        }
    }
}