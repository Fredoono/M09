using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class BilheteVip : Bilhete
    {
        //propriedades
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
        //construtor
        public BilheteVip(double Valor_extra, double valor):base(valor)
        {
            this.Valor_extra = Valor_extra;
        }
        public BilheteVip()
        { this.valor = 0; }
    }

}
