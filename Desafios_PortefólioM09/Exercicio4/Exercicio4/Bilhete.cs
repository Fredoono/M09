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
        double valor;

        //métedos
        public virtual double MostrarValor()
            {return valor;}

        //gets
        public double GetValor()
            {
                return valor;
            }
    }

}
