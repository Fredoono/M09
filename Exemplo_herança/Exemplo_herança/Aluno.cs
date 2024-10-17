using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_herança
{
    internal class Aluno:Pessoa
    {
        //propreidades
        string turma;
        int numero;

        //gets
        public int Getnumero(int numero) { return numero; }
        public string Getturma(string turma) { return turma; }

        //sets
        public void Setnumero(int _numero)
        { numero = _numero; }
        public void Setturma(string _turma)
        { turma = _turma;}

        //construtor (necessário para a classe ser deriada)     
        public Aluno(string nome, DateTime data_nasc, string n_ident, string n_proces, int numero, string turma) : base(nome, data_nasc, n_ident, n_proces)
        {
            this.turma = turma;
            this.numero = numero;
        }

        public override string ToString()
        {
            return "turma: " + turma + "\nnumero: " + numero;
        }
    }
}
