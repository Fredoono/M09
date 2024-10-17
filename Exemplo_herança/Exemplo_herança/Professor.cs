using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_herança
{
    internal class Professor:Pessoa
    {
        //propriedades
        float salario;
        string habilitacao;

        //gets
        public int Getsalario(int numero) { return numero; }
        public string Gethabilitacao(string habilitacao) { return habilitacao; }

        //sets
        public void Setsalario(int _salario)
        { salario = _salario;}
        public void Sethabilitacao(string _habilitacao)
        { habilitacao = _habilitacao;}
        //construtor
        public Professor(string nome, DateTime data_nasc, string n_ident, string n_proces, int salario, string habilitacao):base(nome, data_nasc, n_ident, n_proces)
        {
            this.habilitacao = habilitacao;
            this.salario = salario;
        }

        public override string ToString()
        {
            return "salario: " + salario + "\nHabilitação: " + habilitacao;
        }
    }
}
