using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();
            Console.WriteLine(Quadrado.diagonal(quadrado));
            Console.WriteLine(Quadrado.area(quadrado));
            Console.WriteLine(Quadrado.perimetro(quadrado));
            Console.ReadLine();
        }
    }
}
