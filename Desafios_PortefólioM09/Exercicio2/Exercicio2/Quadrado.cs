using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Quadrado
    {
        double lado;

        //construtor
        public Quadrado(double lado=1)
        {
            if (lado > 20 || lado < 0)
            { lado = 1; }
            else {this.lado = lado;}
        }

        public static double area(Quadrado quadrado)
        { return quadrado.lado * quadrado.lado; }

        public static double diagonal(Quadrado quadrado)
        {  return Math.Sqrt(2)*quadrado.lado; }

        public static double perimetro(Quadrado quadrado)
        {
            return quadrado.lado * 4;
        }
    }


}
