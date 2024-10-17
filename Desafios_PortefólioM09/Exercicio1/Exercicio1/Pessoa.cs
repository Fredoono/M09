using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Pessoa
    {
        string nome;
        int idade;
        string cidade;

        /// construtor  
        public Pessoa(string nome, int idade, string cidade)
        {
            this.nome = nome;
            this.idade = idade;
            this.cidade = cidade;
        }

        public static void mostrarDados(Pessoa pessoa)
        {
            Console.WriteLine($"nome: {pessoa.nome} idade: {pessoa.idade}anos cidade: {pessoa.cidade}");
        }
    }
}
