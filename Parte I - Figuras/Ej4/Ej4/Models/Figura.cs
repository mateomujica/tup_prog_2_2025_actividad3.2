using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4.Models
{
    abstract class Figura : IFigura, IComparable
    {
        abstract public double CalcularArea();

        abstract public double CalcularPerimetro();

        public int CompareTo(object obj)
        {
            Figura figura = obj as Figura;

            if (figura != null)
            {
                return this.CalcularArea().CompareTo(figura.CalcularArea());
            }
            return -1;


        }
    }
}
