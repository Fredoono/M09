using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeículos
{
    internal class Program
    {
        public static int Menu()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("´Gestor de veículos");
            Console.WriteLine("===========================");
            Console.WriteLine("1-adicionar 2-");
            int op = 0;
            op = Convert.ToInt16(Console.ReadLine());
            return op;
        }

        static void Main(string[] args)
        {
            int opcao = 1;
            while (opcao != 0)
            {
                int menu_op = Menu();
                opcao = menu_op;
                if (opcao == 1)
                    {
                    Veículo.CriarVeículo();
                    }
                if (opcao == 2)
            }
        }
    }
}
