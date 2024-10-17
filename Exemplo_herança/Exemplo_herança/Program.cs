    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Fred", DateTime.Today, "24585","ã11667702");
            Aluno aluno = new Aluno("Afonso", DateTime.Today, "245245", "a245245", 1, "11T");
            Professor professor = new Professor("Fernando", DateTime.Today, "235472","a3242342",90000,"gay");

            Console.WriteLine(professor.toString());
            Console.WriteLine(aluno.toString());
            Console.WriteLine(pessoa.toString());
            Console.ReadLine();
        }
    }
}
