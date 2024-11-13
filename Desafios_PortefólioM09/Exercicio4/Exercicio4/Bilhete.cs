using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Bilhete
    {
        //propriadades
        protected double valor;

        //métedos
        public virtual double MostrarValor()
            {return valor;}

        //gets
        public double GetValor()
            {
                return valor;
            }
        //construtor
        public Bilhete(double valor)
            { this.valor = valor; }

        public Bilhete()
        { this.valor = 0; }
    }

}
