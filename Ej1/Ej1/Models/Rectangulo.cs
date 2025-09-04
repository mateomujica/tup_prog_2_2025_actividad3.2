using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ej1.Models
{
    internal class Rectangulo : IFigura
    {
        public double Largo { get; private set; }
        public double Ancho { get; private set; }

        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }

        public double CalcularArea()
        {
            return Largo * Ancho;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largo + Ancho);
        }

        //public int CompareTo(objeto obj)
        //{

        //}

        public override string ToString()
        {
            return $"Rectangulo - Area : {CalcularArea():f2} - Perimetro : {CalcularPerimetro():f2}";
        }
    }
}
