using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cuota
    {
        public Cuota(int idsocio, int mes, int anio, bool pagado, decimal monto) 
        {
            idSocio = idsocio;
            Mes = mes;
            Anio = anio;    
            Pagado = pagado;
            Monto = monto;       
        }  
        public int idSocio { get; set; }
        public int Mes {get; set; }    
        public int Anio { get; set; }  
        public bool Pagado { get; set; }
        public decimal Monto { get; set; }

    }
}