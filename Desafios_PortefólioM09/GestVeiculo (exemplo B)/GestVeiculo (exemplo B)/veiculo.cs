using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestVeiculo__exemplo_B_
{
    internal class veiculo
    {
        //propriedades
        string matricula;
        int ano;
        Proprietario proprietario;

        //gets
        public string GetMatricula() { return matricula; }
        public int GetAno() {return ano; }
        public Proprietario GetProprietario() { return proprietario; }
        //sets
        public void SetMatricula(string matricula) {
            if (matricula.Length >= 6)
            { this.matricula = matricula; }
            else {this.matricula="0"; }
                
        }
        public void SetAno(int ano) { this.ano = ano; }
        public void SetProprietario(Proprietario proprietario) { this.proprietario = proprietario;}
        
        //construtor
        public veiculo(string matricula, int ano, Proprietario proprietario)
        { 
            this.matricula=matricula;
            this.ano=ano;
            this.proprietario=proprietario;
        }
        public veiculo(string matricula, int ano)
        {
            this.matricula = matricula;
            this.ano = ano;
        }
        //metedos
        public void MostrarTudo()
        {
            Console.WriteLine($"matricula: {matricula}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine(proprietario.DevolveInfo());
        }

        public virtual string DevolveInfo() 
        {
            return proprietario.DevolveInfo() + $"ano: {ano}, matricula: {matricula}" ;
        }

    }
}
