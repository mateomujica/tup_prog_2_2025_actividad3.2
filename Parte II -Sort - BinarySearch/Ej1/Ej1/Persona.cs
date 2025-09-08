using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Persona : IComparable 
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Persona (int dni, string nombre)
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }
        public string ToString()
        {
            return $"{DNI} - {Nombre}";
        }

        public int CompareTo(object obj)
        {
            Persona nueva = obj as Persona;

            if (nueva !=null)
            {
                return this.DNI.CompareTo(nueva.DNI);
            }
            return -1;
        }



    }
}
