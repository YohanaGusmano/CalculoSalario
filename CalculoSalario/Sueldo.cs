using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario
{
    public class Sueldo
    {
        private int diasLaborados;

        public int DiasLaborados { get; set; }
    

    // Metodo para calcular sueldo
    public decimal CalcularSueldo  (int diasLab, decimal valorDia)
        {
            decimal totalSalario = diasLab * valorDia;
            
            return totalSalario;

        }


    }
    
}
