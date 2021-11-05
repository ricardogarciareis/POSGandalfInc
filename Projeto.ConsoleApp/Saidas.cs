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
        string opcao = "1_";
        public void ApresentarMenu()
        {
            while(opcao != "0_")
            {
                Menu();
                switch (opcao)
                {
                    case "1A":
                        ListarUtilizadores();
                        break;
                    case "2A":
                        ListarClientes();
                        break;
                    case "3A":
                        ListarArtigos();
                        break;
                    case "5A":
                        ListarLojas();
                        break;
                    case "6A":
                        ListarFornecedores();
                        break;
                    case "7A":
                        ListarCategoriasArtigos();
                        break;
                    default:
                        break;
                }
            }
        }

        public void Menu()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                      POS GANDALF INC MENU                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| 1_ - GESTÃO DE UTILIZADORES                                     |");
            Console.WriteLine("|   1A - LISTAR TODOS OS UTILIZADORES                             |");
            Console.WriteLine("|   1B - OBTER DADOS DO UTILIZADOR                                |");
            Console.WriteLine("|   1C - CRIAR NOVO UTILIZADOR                                    |");
            Console.WriteLine("|   1D - ALTERAR DADOS DO UTILIZADOR                              |");
            Console.WriteLine("|   1E - REMOVER UTILIZADOR                                       |");
            Console.WriteLine("| 2_ - GESTÃO DE CLIENTES                                         |");
            Console.WriteLine("|   2A - LISTAR TODOS OS CLIENTES                                 |");
            Console.WriteLine("|   2B - OBTER DADOS DO CLIENTE                                   |");
            Console.WriteLine("|   2C - CRIAR NOVO CLIENTE                                       |");
            Console.WriteLine("|   2D - ALTERAR DADOS DO CLIENTE                                 |");
            Console.WriteLine("|   2E - REMOVER CLIENTE                                          |");
            Console.WriteLine("| 3_ - GESTÃO DE ARTIGOS                                          |");
            Console.WriteLine("|   3A - LISTAR TODOS OS ARTIGOS                                  |");
            Console.WriteLine("|   3B - OBTER DADOS DO ARTIGO                                    |");
            Console.WriteLine("|   3C - CRIAR NOVO ARTIGO                                        |");
            Console.WriteLine("|   3D - ALTERAR DADOS DO ARTIGO                                  |");
            Console.WriteLine("|   3E - REMOVER ARTIGO                                           |");
            Console.WriteLine("| 4_ - GESTÃO DE VENDAS                                           |");
            Console.WriteLine("|   4A - LISTAR TODAS OS VENDAS                                   |");
            Console.WriteLine("|   4B - OBTER DADOS DA VENDA                                     |");
            Console.WriteLine("|   4C - CRIAR NOVA VENDA                                         |");
            Console.WriteLine("|   4D - ALTERAR DADOS DA VENDA                                   |");
            Console.WriteLine("|   4E - REMOVER VENDA                                            |");
            Console.WriteLine("| 5_ - GESTÃO DE LOJAS                                            |");
            Console.WriteLine("|   5A - LISTAR TODAS AS LOJAS                                    |");
            Console.WriteLine("|   5B - OBTER DADOS DA LOJA                                      |");
            Console.WriteLine("|   5C - CRIAR NOVA LOJA                                          |");
            Console.WriteLine("|   5D - ALTERAR DADOS DA LOJA                                    |");
            Console.WriteLine("|   5E - REMOVER LOJA                                             |");
            Console.WriteLine("| 0_ - SAIR                                                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
            Console.WriteLine("+-----------------------------------------------------------------+");
            //Console.WriteLine($"| Opção escolhida: {opcao}                                             |");
        }

        public void SubMenu1()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                      POS GANDALF INC MENU                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| 1_ - GESTÃO DE UTILIZADORES                                     |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   1A - LISTAR TODOS OS UTILIZADORES                             |");
            Console.WriteLine("|   1B - OBTER DADOS DO UTILIZADOR                                |");
            Console.WriteLine("|   1C - CRIAR NOVO UTILIZADOR                                    |");
            Console.WriteLine("|   1D - ALTERAR DADOS DO UTILIZADOR                              |");
            Console.WriteLine("|   1E - REMOVER UTILIZADOR                                       |");
            Console.WriteLine("| 0_ - SAIR                                                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            opcao = Console.ReadLine().ToUpper();
            Console.WriteLine("+-----------------------------------------------------------------+");
            //Console.WriteLine($"| Opção escolhida: {opcao}                                             |");
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
        }

        public void ListarLojas()
        {
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                   CONSULTA DE TODAS AS LOJAS                    |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            var repo = new RepositorioLoja();
            var listaLojas = repo.ObterTodos();
            foreach (var item in listaLojas)
            {
                Console.WriteLine(item);
            }
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
        }

    }
}
