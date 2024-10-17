using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class BilheteVip:Bilhete
    {
        double Valor_extra;

        //métedo que tetorna o valor total
        public override double MostrarValor()
        {
            double Valor = GetValor();
            return Valor + Valor_extra;
        }

        public void MostrarDiferença()
        {
            double Total = GetValor() + Valor_extra;
            Console.WriteLine(Total);
        }
    }

}
