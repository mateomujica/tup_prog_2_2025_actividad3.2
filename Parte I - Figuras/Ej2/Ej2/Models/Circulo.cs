using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Models
{
    abstract class Circulo:Figura 
    {
        public double Radio { get; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        override public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        override public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        //public int CompareTo (objeto obj)
        //{

        //}

        public override string ToString()
        {
            return $"Circulo - Area : {CalcularArea()} - Perimetro : {CalcularPerimetro()}";
        }

    }
}
