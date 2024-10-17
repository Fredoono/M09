using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeículos
{
    internal class Motor
    {
        string nome;
        int potencia;
        string combusticvel;
        /// <summary>
        /// cria um novo motor
        /// </summary>
        /// <returns></returns>
        public static Object CriarMotor()
        {
            Console.WriteLine("insira o nome do Motor");
            string nome = Console.ReadLine();

            Console.WriteLine("insira a potencia do motor");
            int potencia = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("insira o tipo de combustível para este motor");
            string combustivel = Console.ReadLine();

            
            Motor _motor = new Motor();
            _motor.nome = nome;
            _motor.potencia = potencia;
            _motor.combusticvel = combustivel;
            return _motor;
        }
        public Motor(int p, string m, string n)
        {
            potencia = p;
            matricula = m;
            nome = n;
        }
    }
}
