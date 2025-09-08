using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3.Models
{
    internal class Rectangulo : IFigura, IComparable
    {

        public double Largo { get; private set; }
        public double Ancho { get; private set; }

        public Rectangulo (double largo, double ancho)
        {
            this.Largo= largo;
            this.Ancho= ancho;
        }

        public double CalcularArea()
        {
            return Largo * Ancho;
        }

        public double CalcularPerimetro()
        {
           return 2*(Largo*Ancho);
            
        }

        public int CompareTo(object obj)
        {

            IFigura fig = obj as Rectangulo;
            if (fig != null)
            {
                return this.CalcularArea().CompareTo(fig.CalcularArea());
                
            }
            return -1;
        }
        public override string ToString()
        {
           return $"Rectangulo: {CalcularArea()} / {CalcularPerimetro()}";
        }





        
        


    }
}
