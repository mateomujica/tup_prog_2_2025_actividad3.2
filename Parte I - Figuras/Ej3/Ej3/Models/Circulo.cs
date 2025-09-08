using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3.Models
{
    internal class Circulo : IFigura, IComparable
    {

        public double Radio { get; }

        public Circulo (double radio)
        {
            this.Radio= radio; 
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public int CompareTo (object obj)
        {
            IFigura fig = obj as Circulo;
            if (fig != null)
            {
                return this.CalcularArea().CompareTo(fig.CalcularArea());
               
            }
            return -1;
        }
        public override string ToString()
        {
            return $"Circulo: {CalcularArea()} / {CalcularPerimetro()}";
        }
    }
}
