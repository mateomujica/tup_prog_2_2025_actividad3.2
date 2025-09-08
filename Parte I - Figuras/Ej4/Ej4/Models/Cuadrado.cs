using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4.Models
{
    internal class Cuadrado : Rectangulo
    {
        
        public Cuadrado(double lado) : base (lado,lado)
        {
            
        }

        public override string ToString()
        {
            return $"Cuadrado {CalcularArea()} / {CalcularPerimetro()}";
        }
    }
}
