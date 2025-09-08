using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4.Models
{
    internal class Circulo : Figura 
    {
        public double Radio { get; }

        public Circulo(double radio)
        {
            this.Radio = radio; 
        }

        public override double CalcularArea()
        {
            return (Math.PI * Math.Pow(Radio, 2));
        }

        public override double CalcularPerimetro()
        {
            return (2 * Math.PI * Radio);
        }

        public override string ToString()
        {
            return $"Circulo: {CalcularArea():f2} / {CalcularPerimetro():f2}";
        }


    }
}
