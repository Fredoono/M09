using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Program
    {
        
        private static int Menu()
        {
            Console.WriteLine("1-adicionar bilhetes 2-mostrar detalhes dos bilhetes 3- mostrar quando o bilhete vip vale a mais, 0- fechar programa");
            int op = Convert.ToInt16(Console.ReadLine());
            return op;
        }

       
        static void Main(string[] args)
        {
            Bilhete bilhete=new Bilhete();
            BilheteVip bilheteVip=new BilheteVip();
            int op;
            bool criado = false;
            do
            {
                op = Menu();

                if (op == 1)
                {

                    if (criado)
                    { Console.WriteLine("já existem bilhetes"); }
                    else
                    {
                        Console.WriteLine("Preço normal");
                        double preco_normal = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Preço VIP");
                        double preco_vip = Convert.ToDouble(Console.ReadLine());
                        bilhete = new Bilhete(preco_normal);
                        bilheteVip = new BilheteVip(preco_vip, preco_normal);
                        criado= true;

                    }
                }
                else if (op == 2)
                {
                    if (criado)
                    {
                        Console.WriteLine("valor normal: ");
                        Console.WriteLine(bilhete.MostrarValor());
                        Console.WriteLine("valor vip: ");
                        Console.WriteLine(bilheteVip.MostrarValor());
                    }
                    else
                    {
                        Console.WriteLine("ainda nao criou os bilhetes");
                    }

                }
                else if (op == 3)
                        {
                    bilheteVip.MostrarDiferença();
                        }


            } while (op != 0);



        }

    }
}
