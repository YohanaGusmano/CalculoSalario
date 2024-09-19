using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario
{
    public class Empleado
    {
         
        private string nombre;
        private string identificacion;
        private string asignacionDia;


        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public Decimal AsignacionDia { get; set; }
    }

}

