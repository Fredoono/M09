using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestVeiculo__exemplo_B_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proprietario p = new Proprietario("Fred Joca", "vs-696969", "2222222");

            veiculo v= new veiculo("19-mt-78",1999,p);

            Console.WriteLine(v.DevolveInfo());

            Console.ReadLine();
        }
    }
}
