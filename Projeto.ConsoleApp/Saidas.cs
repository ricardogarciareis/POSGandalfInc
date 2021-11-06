using Projeto.Lib.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.ConsoleApp
{
    public class Saidas
    {
        string opcao = "1";
        public void ApresentarMenu()
        {
            Menu();
            while (opcao != "S")
            {
                switch (opcao)
                {
                    case "1":
                        SubMenu1();
                        while (opcao != "S")
                        {
                            switch (opcao)
                            {
                                //case "1A":
                                    //ListarVendas()
                                    //break;
                                default:
                                    Console.WriteLine("| Escolha uma opção válida                                        |");
                                    SubMenu1();
                                    break;
                            }
                        }
                        Menu();
                        break;
                    case "2":
                        SubMenu2();
                        while (opcao != "S")
                        {
                            switch (opcao)
                            {
                                case "2A":
                                    ListarArtigos();
                                    break;
                                default:
                                    Console.WriteLine("| Escolha uma opção válida                                        |");
                                    SubMenu2();
                                    break;
                            }
                        }
                        Menu();
                        break;
                    case "3":
                        SubMenu3();
                        while (opcao != "S")
                        {
                            switch (opcao)
                            {
                                case "3A":
                                    ListarCategoriasArtigos();
                                    break;
                                default:
                                    Console.WriteLine("| Escolha uma opção válida                                        |");
                                    SubMenu3();
                                    break;
                            }
                        }
                        Menu();
                        break;
                    case "4":
                        SubMenu4();
                        while (opcao != "S")
                        {
                            switch (opcao)
                            {
                                case "4A":
                                    ListarClientes();
                                    break;
                                default:
                                    Console.WriteLine("| Escolha uma opção válida                                        |");
                                    SubMenu4();
                                    break;
                            }
                        }
                        Menu();
                        break;
                    case "5":
                        SubMenu5();
                        while (opcao != "S")
                        {
                            switch (opcao)
                            {
                                case "5A":
                                    ListarFornecedores();
                                    break;
                                default:
                                    Console.WriteLine("| Escolha uma opção válida                                        |");
                                    SubMenu5();
                                    break;
                            }
                        }
                        Menu();
                        break;
                    case "6":
                        SubMenu6();
                        while (opcao != "S")
                        {
                            switch (opcao)
                            {
                                case "6A":
                                    ListarUtilizadores();
                                    break;
                                default:
                                    Console.WriteLine("| Escolha uma opção válida                                        |");
                                    SubMenu6();
                                    break;
                            }
                        }
                        Menu();
                        break;
                    case "7":
                        SubMenu7();
                        while (opcao != "S")
                        {
                            switch (opcao)
                            {
                                //case "7A":
                                    //ListarPontosDeVenda();
                                    //break;
                                default:
                                    Console.WriteLine("| Escolha uma opção válida                                        |");
                                    SubMenu7();
                                    break;
                            }
                        }
                        Menu();
                        break;
                    case "8":
                        SubMenu8();
                        while (opcao != "S")
                        {
                            switch (opcao)
                            {
                                case "8A":
                                    ListarLojas();
                                    break;
                                default:
                                    Console.WriteLine("| Escolha uma opção válida                                        |");
                                    SubMenu8();
                                    break;
                            }
                        }
                        Menu();
                        break;
                    default:
                        Console.WriteLine("| Escolha uma opção válida                                        |");
                        Menu();
                        break;
                }
            }
        }

        public void Menu()
        {
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

        public void SubMenu1()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                      POS GANDALF INC MENU                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| 1 - GESTÃO DE VENDAS                                            |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   1A - LISTAR TODAS OS VENDAS                                   |");
            Console.WriteLine("|   1B - OBTER DADOS DA VENDA                                     |");
            Console.WriteLine("|   1C - CRIAR NOVA VENDA                                         |");
            Console.WriteLine("|   1D - ALTERAR DADOS DA VENDA                                   |");
            Console.WriteLine("|   1E - REMOVER VENDA                                            |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        public void SubMenu2()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                      POS GANDALF INC MENU                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| 2 - GESTÃO DE ARTIGOS                                           |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   2A - LISTAR TODOS OS ARTIGOS                                  |");
            Console.WriteLine("|   2B - OBTER DADOS DO ARTIGO                                    |");
            Console.WriteLine("|   2C - CRIAR NOVO ARTIGO                                        |");
            Console.WriteLine("|   2D - ALTERAR DADOS DO ARTIGO                                  |");
            Console.WriteLine("|   2E - REMOVER ARTIGO                                           |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        public void SubMenu3()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                      POS GANDALF INC MENU                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| 3 - GESTÃO DE CATEGORIAS DE ARTIGOS                             |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   3A - LISTAR TODAS AS CATEGORIAS DE ARTIGOS                    |");
            Console.WriteLine("|   3B - OBTER DADOS DA CATEGORIA DE ARTIGO                       |");
            Console.WriteLine("|   3C - CRIAR NOVA CATEGORIA DE ARTIGO                           |");
            Console.WriteLine("|   3D - ALTERAR DADOS DA CATEGORIA DE ARTIGO                     |");
            Console.WriteLine("|   3E - REMOVER CATEGORIA DE ARTIGO                              |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        public void SubMenu4()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                      POS GANDALF INC MENU                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| 4 - GESTÃO DE CLIENTES                                          |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   4A - LISTAR TODOS OS CLIENTES                                 |");
            Console.WriteLine("|   4B - OBTER DADOS DO CLIENTE                                   |");
            Console.WriteLine("|   4C - CRIAR NOVO CLIENTE                                       |");
            Console.WriteLine("|   4D - ALTERAR DADOS DO CLIENTE                                 |");
            Console.WriteLine("|   4E - REMOVER CLIENTE                                          |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        public void SubMenu5()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                      POS GANDALF INC MENU                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| 5 - GESTÃO DE FORNECEDORES                                      |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   5A - LISTAR TODOS OS FORNECEDORES                             |");
            Console.WriteLine("|   5B - OBTER DADOS DO FORNECEDOR                                |");
            Console.WriteLine("|   5C - CRIAR NOVO FORNECEDOR                                    |");
            Console.WriteLine("|   5D - ALTERAR DADOS DO FORNECEDOR                              |");
            Console.WriteLine("|   5E - REMOVER FORNECEDOR                                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        public void SubMenu6()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                      POS GANDALF INC MENU                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| 6 - GESTÃO DE UTILIZADORES                                      |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   6A - LISTAR TODOS OS UTILIZADORES                             |");
            Console.WriteLine("|   6B - OBTER DADOS DO UTILIZADOR                                |");
            Console.WriteLine("|   6C - CRIAR NOVO UTILIZADOR                                    |");
            Console.WriteLine("|   6D - ALTERAR DADOS DO UTILIZADOR                              |");
            Console.WriteLine("|   6E - REMOVER UTILIZADOR                                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        public void SubMenu7()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                      POS GANDALF INC MENU                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| 7 - GESTÃO DE PONTOS DE VENDA                                   |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   7A - LISTAR TODOS OS PONTOS DE VENDA                          |");
            Console.WriteLine("|   7B - OBTER DADOS DO PONTO DE VENDA                            |");
            Console.WriteLine("|   7C - CRIAR NOVO PONTO DE VENDA                                |");
            Console.WriteLine("|   7D - ALTERAR DADOS DO PONTO DE VENDA                          |");
            Console.WriteLine("|   7E - REMOVER PONTO DE VENDA                                   |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        public void SubMenu8()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                      POS GANDALF INC MENU                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| 8 - GESTÃO DE LOJAS                                             |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   8A - LISTAR TODAS AS LOJAS                                    |");
            Console.WriteLine("|   8B - OBTER DADOS DA LOJA                                      |");
            Console.WriteLine("|   8C - CRIAR NOVA LOJA                                          |");
            Console.WriteLine("|   8D - ALTERAR DADOS DA LOJA                                    |");
            Console.WriteLine("|   8E - REMOVER LOJA                                             |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }


        public void ListarVendas()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                  CONSULTA DE TODAS AS VENDAS                    |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            //var repo = new RepositorioVenda();
            //var listaVendass = repo.ObterTodos();
            //foreach (var item in listaVendas)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        public void ListarArtigos()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                  CONSULTA DE TODOS OS ARTIGOS                   |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            var repo = new RepositorioArtigo();
            var listaArtigos = repo.ObterTodos();
            foreach (var item in listaArtigos)
            {
                Console.OutputEncoding = Encoding.UTF8;  //Utilizado para reconhecer o símbolo €
                Console.WriteLine(item);
            }
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        public void ListarCategoriasArtigos()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|           CONSULTA DE TODAS AS CATEGORIAS DE ARTIGOS            |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            var repo = new RepositorioCategoriaArtigo();
            var listaCategoriasArtigos = repo.ObterTodos();
            foreach (var item in listaCategoriasArtigos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        public void ListarClientes()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                 CONSULTA DE TODOS OS CLIENTES                   |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            var repo = new RepositorioCliente();
            var listaClientes = repo.ObterTodos();
            foreach(var item in listaClientes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        public void ListarFornecedores()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|               CONSULTA DE TODOS OS FORNECEDORES                 |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            var repo = new RepositorioFornecedor();
            var listaFornecedores = repo.ObterTodos();
            foreach (var item in listaFornecedores)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        public void ListarUtilizadores()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|               CONSULTA DE TODOS OS UTILIZADORES                 |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            var repo = new RepositorioUtilizador();
            var listaUtilizadores = repo.ObterTodos();
            foreach (var item in listaUtilizadores)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        public void ListarPontosDeVenda()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|             CONSULTA DE TODOS OS PONTOS DE VENDA                |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            //var repo = new RepositorioPontoDeVenda();
            //var listaPontosDeVenda = repo.ObterTodos();
            //foreach (var item in listaPontosDeVenda)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        public void ListarLojas()
        {
            Console.WriteLine("|                   CONSULTA DE TODAS AS LOJAS                    |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            var repo = new RepositorioLoja();
            var listaLojas = repo.ObterTodos();
            foreach (var item in listaLojas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("| S - SAIR                                                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
        }

        

        

    }
}
