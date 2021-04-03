using System;
using TesteCrud.Menu;
using System.Collections.Generic;
using TesteCrud.Entities;

namespace TesteCrud
{
    class Program
    {

        static void Main(string[] args)
        {
            int Option = 0;
            int IdCount = 0;
            int AuxOperations = 0;
            List<Client> client = new List<Client>();

            try
            {
                while (Option != 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("╔═══════════════ MENU DE OPÇÕES ════════════════╗    ");
                    Console.WriteLine("║ 1 CADASTRAR CLIENTES                          ║    ");
                    Console.WriteLine("║                                               ║    ");
                    Console.WriteLine("║ 2 CONSULTAR CLIENTES                          ║    ");
                    Console.WriteLine("║                                               ║    ");
                    Console.WriteLine("║ 3 ATUALIZAR CLIENTE                           ║    ");
                    Console.WriteLine("║                                               ║    ");
                    Console.WriteLine("║ 4 DELETAR CLIENTE                             ║    ");
                    Console.WriteLine("║                                               ║    ");
                    Console.WriteLine("║ 5 SAIR                                        ║    ");
                    Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
                    Console.WriteLine(" ");

                    Console.Write("DIGITE UMA OPÇÃO : ");
                    Option = int.Parse(Console.ReadLine());



                    switch (Option)
                    {
                        case 1:

                            Console.Write("Favor informar o nome do Cliente: ");
                            Console.WriteLine(" ");
                            string name = Console.ReadLine();
                            Console.Write("Favor informar o CPF do Cliente: ");
                            string cpf = Console.ReadLine();
                            IdCount += 1;
                            client.Add(new Client(IdCount, name, cpf));
                            Console.WriteLine();
                            Console.WriteLine("Cadastro realizado com sucesso!!!\n\nPressione enter para continuar...");
                            Console.ReadLine();
                            Option = 0;
                            Console.Clear();



                            break;

                        case 2:                            
                            foreach (Client obj in client)
                            {
                                Console.WriteLine();
                                Console.WriteLine(obj);
                                Console.WriteLine();
                            }
                            Console.ReadLine();
                            Option = 0;
                            Console.Clear();
                            break;

                        case 3:
                            Console.Write("Informe o Id do cliente a ser atualizado: ");
                            AuxOperations = int.Parse(Console.ReadLine());
                            Client cli = client.Find(x => x.Id == AuxOperations);
                            Console.Write("Favor informar o nome do Cliente: ");
                            Console.WriteLine(" ");
                            string Auxname = Console.ReadLine();
                            Console.Write("Favor informar o CPF do Cliente: ");
                            string Auxcpf = Console.ReadLine();
                            cli.UpdateClient(Auxname, Auxcpf);
                            Console.WriteLine();
                            Console.WriteLine("Cadastro realizado com sucesso!!!\n\nPressione enter para continuar...");
                            Console.ReadLine();
                            Option = 0;
                            Console.Clear();
                            break;

                        case 4:
                            Console.Write("Favor informar o Id do cliente para excluir: ");
                            Console.WriteLine();
                            AuxOperations = int.Parse(Console.ReadLine());
                            client.RemoveAll(x => x.Id == AuxOperations);
                            Console.WriteLine();
                            Console.WriteLine("Cadastro realizado com sucesso!!!\n\nPressione enter para continuar...");
                            Console.ReadLine();
                            Option = 0;
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("Opcao invalida, favor escolha uma opcao do menu");
                            Console.ReadLine();
                            Option = 0;
                            Console.Clear();
                            break;
                    }

                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Error! " + e.Message);

            }
        }
    }
}
