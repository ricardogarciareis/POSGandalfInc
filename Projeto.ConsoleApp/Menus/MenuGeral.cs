using System;

namespace Projeto.ConsoleApp
{
    public class MenuGeral
    {
        string opcao = "1";

        public void ApresentarMenu()
        {
            var subMenu1 = new SubMenu1();
            var subMenu2 = new SubMenu2();
            var subMenu3 = new SubMenu3();
            var subMenu4 = new SubMenu4();
            var subMenu5 = new SubMenu5();
            var subMenu6 = new SubMenu6();
            var subMenu7 = new SubMenu7();
            var subMenu8 = new SubMenu8();
            MostrarMenu();
            while (opcao != "S")
            {
                switch (opcao)
                {
                    case "1":
                        subMenu1.ApresentarSubMenu();
                        break;
                    case "2":
                        subMenu2.ApresentarSubMenu();
                        break;
                    case "3":
                        subMenu3.ApresentarSubMenu();
                        break;
                    case "4":
                        subMenu4.ApresentarSubMenu();
                        break;
                    case "5":
                        subMenu5.ApresentarSubMenu();
                        break;
                    case "6":
                        subMenu6.ApresentarSubMenu();
                        break;
                    case "7":
                        subMenu7.ApresentarSubMenu();
                        break;
                    case "8":
                        subMenu8.ApresentarSubMenu();
                        break;
                    default:
                        Console.WriteLine("| Escolha uma opção válida                                        |");
                        MostrarMenu();
                        break;
                }
            }
        }

        public void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                      POS GANDALF INC MENU                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| 1 - GESTÃO DE VENDAS                                            |");
            Console.WriteLine("| 2 - GESTÃO DE ARTIGOS                                           |");
            Console.WriteLine("| 3 - GESTÃO DE CATEGORIAS DE ARTIGOS                             |");
            Console.WriteLine("| 4 - GESTÃO DE CLIENTES                                          |");
            Console.WriteLine("| 5 - GESTÃO DE FORNECEDORES                                      |");
            Console.WriteLine("| 6 - GESTÃO DE UTILIZADORES                                      |");
            Console.WriteLine("| 7 - GESTÃO DE PONTOS DE VENDA                                   |");
            Console.WriteLine("| 8 - GESTÃO DE LOJAS                                             |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }
    }
}
