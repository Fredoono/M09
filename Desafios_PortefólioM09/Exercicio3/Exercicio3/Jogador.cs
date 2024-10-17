using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Jogador
    {
        string nome;
        int ano_de_nascimento;
        string nacionalidade;
        string posicao;
        float altura;
        float peso;

        //gets
        public string Getnome()
            { return nome; }
        public int Getano_de_nascimento()
            { return ano_de_nascimento;}
        public string Getnacionalidade() 
            { return nacionalidade;}
        public float Getaltura()
            { return altura;}
        public float Getpeso() 
            { return peso; }
        public string Getposicao()
            { return posicao;}

        //sets
        public void Setnome(string nome)
        { this.nome = nome; }
        public void Setano_de_nascimento(int ano_de_nascimento)
        { this.ano_de_nascimento = ano_de_nascimento; }
        public void Setnacionalidade(string nacionalidade) 
        { this.nacionalidade = nacionalidade;}
        public void Setaltura(float altura)
        { 
            this.altura = altura;
        }
        //calcular idade do jogador
        public double CalcularData(Jogador jogador)
        {
            return 2024 - jogador.ano_de_nascimento;
        }
        //mostra todos os dados do jogador
        public void MostrarDados(Jogador jogador)
        {
            Console.WriteLine($"nome: {jogador.nome}, ano de nascimento: {jogador.ano_de_nascimento}, nacionalidade: {jogador.nacionalidade}, altura: {jogador.altura}, posição {jogador.posicao}, peso: {jogador.peso}");
        }
        //mostra a quanto falta para se aposentar
        public void AposentarQuando(Jogador jogador)
            { 
                double idade = CalcularData(jogador);
            double aposentar = 0;
            if (jogador.posicao == "defesa")
            {
                aposentar = 40 - idade;
            }
            if (jogador.posicao == "meio-campo")
            {
                aposentar = 38 - idade;
            }
            if (jogador.posicao == "atacante")
            {
                aposentar = 35 - idade;
            }
            Console.WriteLine($"o jogador deve se aposentar em {aposentar} anos.");
            }

    }

}
