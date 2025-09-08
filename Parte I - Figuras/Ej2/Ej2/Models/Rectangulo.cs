using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Models
{
    internal class Rectangulo : Figura 
    {
        public double Largo { get; private set; }
        public double Ancho { get; private set; }

        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        override public double CalcularArea()
        {
            return Largo * Ancho;
        }

        override public double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }

        //public int CompareTo(objeto obj)
        //{

        //}

        override public string ToString()
        {
            return $"Rectangulo - Area : {CalcularArea():f2} - Perimetro : {CalcularPerimetro():f2}";
        }
    }
}
