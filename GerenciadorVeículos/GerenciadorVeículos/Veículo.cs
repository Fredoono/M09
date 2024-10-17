using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeículos
{
    internal class Veículo
    {
        string marca;
        string matricula;
        object motor;
        /// <summary>
        /// função que cria um  novo veículo e um novo motor caso seja preciso
        /// </summary>
        public static Object CriarVeículo()
        {
            Console.WriteLine("insira a marca do veículo");
            string marca = Console.ReadLine();
            Console.WriteLine("insira a marca do veículo");
            string matricula = Console.ReadLine();
            Console.WriteLine("Deseja criar um novo motor para este veículo");
            string opcao = Console.ReadLine();
            Veículo veiculo = new Veículo();
            return veiculo;
        }

        public string GetMarca()
            { return marca; }
        public void SetMarca(string marca)
            { this.marca = marca; }
    }
}
