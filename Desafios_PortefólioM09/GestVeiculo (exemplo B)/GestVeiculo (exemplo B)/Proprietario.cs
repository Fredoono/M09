using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestVeiculo__exemplo_B_
{
    internal class Proprietario
    {
        string nome;
        string numero_carta_condução;
        string numero_identificação_fiscal;

        //gets
        public string GetNome() { return nome; }
        public string GetNumeroCondução() { return numero_carta_condução; }
        public string GetNumeroCarta() { return numero_identificação_fiscal; }

        //sets
        public void SetNome(string nome) { this.nome = nome; }
        public void SetNumeroCarta(string numero)
        { 
            if (numero.Length >= 6) 
            { this.numero_carta_condução = numero; }
            else
            {
                this.numero_carta_condução = "";
            }
        }
        public void SetNumeroIdentific(string numero) 
        {
            if (numero.Length <= 8)
            {
                this.numero_identificação_fiscal = numero;
            }
        }
        public void MostrarTudo()
        {
            Console.WriteLine($"nome: {nome}, numero da carta de condução: {numero_carta_condução}, nif: {numero_identificação_fiscal}");
        }

        //construtures
        public Proprietario(string nome, string numero_carta_condução, string numero_identificação_fiscal) 
        {
            this.nome = nome;
            this.numero_carta_condução = numero_carta_condução;
            this.numero_identificação_fiscal = numero_identificação_fiscal;
        }
        public Proprietario(string nome, string numero_carta_condução)
        {
            this.nome = nome;
            this.numero_carta_condução = numero_carta_condução;
        }

        public string DevolveInfo()
        { return $"Nome: {nome}, numero da carta: {numero_carta_condução}, nif: {numero_identificação_fiscal}"; }

    }
}
