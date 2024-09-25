using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classeveiculo
{
    internal class Veiculo
    {
        //caracteristicas do veículo
        public string marca;
        public string modelo;
        public string cor;
        public int ano_fabrica;
        public string matricula;
        public int potencia;
        public int cilindrada;
        public int n_portas;

        //comportamento

        public float calcular_velocidade(float dist, float temp)
        {

            return (dist / temp);
        }

        public void visualizar_info()
        {
            Console.WriteLine("o veiculo " + marca + " " + modelo + " possui a cilindrada " + cilindrada + "cc");

        }

    }
}
