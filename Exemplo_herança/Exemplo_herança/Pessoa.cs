using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_herança
{
    internal class Pessoa
    {
        //propriadades
        string nome;
        DateTime data_nasc;
        string N_ident;
        string N_proces;


        //gets
        public string GetNome() { return nome; }
        public string GetN_indent() { return N_ident;}
        public string GetN_proces() { return N_proces;}
       public DateTime GetData_nasc() { return data_nasc;}

        //Sets
        public void SetNome(string _nome)
            { nome = _nome; }
        public void SetN_ident(string _N_ident)
        { N_ident = _N_ident; }
        public void SetN_proces(string _proces)
        { N_proces = _proces;}

        //construtor
        public Pessoa(string nome, DateTime data_nasc, string n_ident, string n_proces)
        {
            this.nome = nome;
            this.data_nasc = data_nasc;
            N_ident = n_ident;
            N_proces = n_proces;
        }

        //função que revela todos os detalhes dos objetos
        public virtual string toString()
        {
            return "nome: " + nome + " numero de identificação " + N_ident + " numero de processo: " + N_proces + " data de nascimento " + data_nasc;
        }
    }
}
