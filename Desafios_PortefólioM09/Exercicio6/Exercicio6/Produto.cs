using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Produto
    {
        //propriedades
        string nome;
        double precoCusto;
        double precoVenda;
        double margemLucro;

        //gets
        public string getNome()
            { return nome; }
        public double getPrecoCusto() 
            { return precoCusto; }
        public double getprecovenda() 
            {
            return precoVenda;}
        public double getmargemLucro()
            { margemLucro = precoVenda - precoCusto; 
            return margemLucro; }
        public double getmargemLucroPercentagem() 
            {
            if (margemLucro != 0)
                { return (margemLucro*100 / precoCusto); }
            else
                return 0;
             }

        //sets
        public void setNome(string nome)
            { this.nome = nome; }
        public void setPrecoCusto(double precoCusto)
            { this.precoCusto = precoCusto; }
        public void setPrecoVenda(double precoVenda)
            {
            if (precoVenda < precoCusto)
                this.precoVenda = precoVenda;
            else
                Console.WriteLine("O preco de venda nao pode ser inferior ao de compra. ");
            }

        //metedos
        //verifica se os numeros sao positivos (se forem negativos devolve 0)
        private double Verificar_positivo(double n)
        { if (n < 0)
            { return 0; }
            else
                return n;}

        private double verificar_custo(double venda, double custo)
            {if (venda < custo)
            { return 0; }
            else return venda;
           }

        //contrutor
        public Produto(string nome, double precoVenda, double precoCusto)
            { 
                this.nome = nome;
                this.precoVenda = Verificar_positivo(precoVenda);
                this.precoCusto = Verificar_positivo(precoCusto);
            }
     }
}
