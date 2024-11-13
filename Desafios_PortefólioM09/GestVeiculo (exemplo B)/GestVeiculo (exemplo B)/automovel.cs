using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestVeiculo__exemplo_B_
{
    internal class automovel:veiculo
    {
        List<string> combustiveis=new List<string> { };
        string marca;
        string modelo;
        string tipo_de_combustivel;
        double numero_maximo_tanque;
        double consumo_medio;
        //construtor
        public automovel(string marca, string modelo, string tipo_de_combustivel, double numero_maximo_tanque, double consumo_medio, string matricula, int ano, Proprietario proprietario) 
        :base(matricula, ano, proprietario)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.tipo_de_combustivel = tipo_de_combustivel;
            this.numero_maximo_tanque = numero_maximo_tanque;
            this.consumo_medio = consumo_medio;

        }
        //gets
        public string GetMarca(){ return marca; }
        public string GetModelo(){ return modelo; }
        public string GetCombustivel() { return tipo_de_combustivel; }
        public double GetNumeroMaximo() { return numero_maximo_tanque; }
        public double GetConsumo_medio() { return consumo_medio; }

        //sets
        public void SetMarca(string marca) { this.marca = marca; }
        public void SetModelo(string modelo) { this.modelo = modelo; }
        public void SetNumeroMaximo(double numeromaximo) { this.numero_maximo_tanque = numeromaximo;}
        public void SetConsumo_Medio(double consumo_medio) { this.consumo_medio = consumo_medio;}
        public void SetTipoCombustível(string tipo_de_combustivel)
        {
            this.tipo_de_combustivel = tipo_de_combustivel;
        }

        //metedos
        public double CalcularDistancia() {return numero_maximo_tanque*100/ consumo_medio; }

        public double CalcularPreco() 
        {
            if (tipo_de_combustivel == "Gasolina 98" )
            { return 1.954*numero_maximo_tanque;}
            if (tipo_de_combustivel == "gasóleo")
            { return 1.704 * numero_maximo_tanque; }
            if (tipo_de_combustivel == "GPL")
            { return 0.924 * numero_maximo_tanque; }
            else { return 0; }
        }
    }
}
