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
        public void ApresentarMenu()
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
            Console.WriteLine("|   3A - LISTAR TODAS OS VENDA S                                  |");
            Console.WriteLine("|   3B - OBTER DADOS DA VENDA                                     |");
            Console.WriteLine("|   3C - CRIAR NOVA VENDA                                         |");
            Console.WriteLine("|   3D - ALTERAR DADOS DA VENDA                                   |");
            Console.WriteLine("|   3E - REMOVER VENDA                                            |");
            Console.WriteLine("| 0_ - SAIR                                                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            string opcao = Console.ReadLine().ToUpper();
            Console.WriteLine("+-----------------------------------------------------------------+");
            //Console.WriteLine($"| Opção escolhida: {opcao}                                             |");
        
            while(opcao != "0_")
            {

            }
            switch (opcao)
            {
                case "1A":
                    ListarUtilizadores();
                    break;
                case "2A":
                    ListarClientes();
                    break;
                default:
                    break;
            }
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
    }
}
