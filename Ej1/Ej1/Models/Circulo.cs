﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Models
{
    internal class Circulo : IFigura
    {
       public double Radio { get; }

        public Circulo (double radio)
        {
            Radio = radio;
        }
        
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public double CalcularPerimetro()
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
