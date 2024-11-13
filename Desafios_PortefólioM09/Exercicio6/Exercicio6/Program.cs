using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nome do produto");
            string n = Console.ReadLine();
            Console.WriteLine("preço de custo");
            double pc = double.Parse(Console.ReadLine());
            Console.WriteLine("preco de venda");
            double pv = double.Parse(Console.ReadLine());

            Produto produto = new Produto(n, pc, pv);

            Console.WriteLine("preço de custo: " + produto.getPrecoCusto());
            Console.WriteLine("preço de venda: " + produto.getprecovenda());
            Console.WriteLine("margem de lucro" + produto.getmargemLucro());

            Console.ReadLine();

        }
    }
}
