using System;
using TesteCrud.Menu;

namespace TesteCrud
{
    class Program
    {

        static void Main(string[] args)
        {
            int option = 0;

            while (option != 6)
            {
                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("╔═══════════════ MENU DE OPÇÕES ════════════════╗    ");

                Console.WriteLine("║ 1 CADASTRO DE CLIENTES                        ║    ");

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

                option = int.Parse(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        Console.WriteLine("Voce selecionou a opcao 1");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Voce selecionou a opcao 2");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Voce selecionou a opcao 3");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Voce selecionou a opcao 4");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Voce selecionou a opcao 5");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opcao invalida, favor escolha uma opcao do menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            }
        }
    }
}
