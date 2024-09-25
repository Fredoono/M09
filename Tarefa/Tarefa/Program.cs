using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa
{
    internal class Program
    {
        public static List<Tarefa> lista_de_tarefas = new List<Tarefa>();
        public static int Menu()
        {
            Console.WriteLine("GESTOR DE TAREFAS");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("1- adicionar tarefa, \n 2-listar tarefas \n 3- apagar uma tarefa \n" +
                " 4- alterar tarefa  \n 5-sair");

            int escolha = Convert.ToInt16(Console.ReadLine());
            if (escolha > 4 && escolha < 0)
            {
                return 0;
            }
            else
            {
                return escolha;
            }
        }
        private static void Criar_tarefa(int id)
        {
            Console.WriteLine("insira o nome da sua tarefa");
            string nome = Console.ReadLine();

            Console.WriteLine("insira a data limite da sua tarefa");
            string data = Console.ReadLine();

            Console.WriteLine("insira uma descrição da sua tarefa");
            string descrição = Console.ReadLine();



            Tarefa tarefa_nova = new Tarefa();
            tarefa_nova.nome_tarefa = nome;
            tarefa_nova.datalimite = data;
            tarefa_nova.ID_da_tarefa = id;
            tarefa_nova.descrição = descrição;

            lista_de_tarefas.Add(tarefa_nova);
        }

        static void Main(string[] args)
        {
            int id = 0;
            int selecao = 1;
            while (selecao != 0)
            {
                selecao = Menu();

                if (selecao == 1)
                {
                    id++;
                    Criar_tarefa(id);
                }

                if (selecao == 2)
                {
                    foreach (var tarefa in lista_de_tarefas)
                    {
                        Console.WriteLine($"id- {tarefa.ID_da_tarefa} nome- {tarefa.nome_tarefa} data- {tarefa.datalimite} descrição- {tarefa.descrição}");
                        Console.WriteLine("");
                    }
                }
                if (selecao == 3)
                {
                    Console.WriteLine("insira o ID da tarefa que deseja apagar:");
                    string nome = Console.ReadLine();
                    int ID = int.Parse(nome);

                    Tarefa tarefa_apagar = null;

                    foreach (var tarefa in lista_de_tarefas)
                    {
                        if (tarefa.ID_da_tarefa == ID)
                        {
                            tarefa_apagar = tarefa;
                            break;
                        }
                    }
                    if (tarefa_apagar != null)
                    {
                        lista_de_tarefas.Remove(tarefa_apagar);
                        Console.WriteLine("tarefa apagada com sucesso");
                    }
                    }
                if (selecao == 4)
                    { 
                    Console.WriteLine("insira o ID que deseja editar");
                    int ID = Convert.ToInt16(Console.ReadLine());
                    foreach (var tarefa in lista_de_tarefas)
                    {
                        if (tarefa.ID_da_tarefa == ID) 
                            Console.WriteLine("insira o novo nome que deseja editar");
                            string novo_nome = Console.ReadLine();
                            Console.WriteLine("insira a nova data que deseja editar");
                            string novo_dataLimite = Console.ReadLine();
                            Console.WriteLine("insira a nova descrição que deseja editar");
                            string nova_descrição = Console.ReadLine();
                            Console.WriteLine("deseja marcar a tarefa como completa? (sim/nao)");
                            string completo = Console.ReadLine();

                            tarefa.nome_tarefa = novo_nome;
                            tarefa.datalimite = novo_dataLimite;
                            tarefa.descrição = nova_descrição;
                            if (completo == "sim" || completo == "s")
                            {
                                tarefa.está_completa = true;
                            }
                            if (completo == "nao" || completo == "n")
                            {
                                tarefa.está_completa = false;
                            }
                        }
                    }
                }
                }
            }
        }
