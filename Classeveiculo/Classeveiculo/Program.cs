using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classeveiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criar um obejeto do tipo veículo
            Veiculo carro0 = new Veiculo();
            Console.WriteLine(carro0.calcular_velocidade(60, 1));
            carro0.cilindrada = 1200;
            carro0.marca = "opel";
            carro0.modelo = "Corsa";

            Veiculo carro1 = new Veiculo();
            carro1 = new Veiculo();
            carro1.cilindrada = 1900;
            carro1.marca = "aqudi";
            carro1.modelo = "a4";

            carro0.visualizar_info();
            carro1.visualizar_info();

            Console.ReadKey();
        }
    }
}
