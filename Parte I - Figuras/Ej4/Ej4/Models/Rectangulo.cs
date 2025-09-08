using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4.Models
{
    internal class Rectangulo : Figura 
    {
        public double Largo { get; }
        public double Ancho { get; }

        public Rectangulo(double largo, double ancho)
        {
            this.Largo = largo;
            this.Ancho = ancho;
        }

        public override double CalcularArea()
        {
            return Largo * Ancho;
        }

        public override double CalcularPerimetro()
        {
            return  (2 * (Largo * Ancho));
        }

        public override string ToString()
        {
           return $"Rectangulo {CalcularArea()} / {CalcularPerimetro()}";
        }

          

    }
}
