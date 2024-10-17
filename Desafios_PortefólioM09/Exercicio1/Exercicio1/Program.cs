using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Fred", 69, "Cabo Verde");
            Pessoa pessoa2 = new Pessoa("Dan", 0, "Cidade_grande_exemplo");

            Pessoa.mostrarDados(pessoa1);
            Pessoa.mostrarDados(pessoa2);
            Console.ReadLine();
        }
    }
}
