using Projeto.Lib.Repositorios;
using System;

namespace Projeto.ConsoleApp
{
    public class SubMenu1
    {
        string escolha = "1";
        bool testado = false;
        MenuGeral menu = new MenuGeral();

        public void ApresentarSubMenu()
        {
            MostrarSubMenu();
            while (escolha != "R")
            {
                switch (escolha)
                {
                    case "1A":
                        ListarVendas();
                        break;
                    case "1B":
                        ApresentarVendaProcuraNome();
                        break;
                    default:
                        Console.WriteLine("| Escolha uma opção válida                                        |");
                        MostrarSubMenu();
                        break;
                }
            }
            menu.ApresentarMenu();
            Environment.Exit(0);
        }

        public void MostrarSubMenu()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                      POS GANDALF INC MENU                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| 1 - GESTÃO DE VENDAS                                            |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   1A - LISTAR TODAS OS VENDAS                                   |");
            Console.WriteLine("|   1B - OBTER DADOS DA VENDA (PROCURA POR NOME)                  |");
            Console.WriteLine("|   1C - CRIAR NOVA VENDA                                         |");
            Console.WriteLine("|   1D - ALTERAR DADOS DA VENDA                                   |");
            Console.WriteLine("|   1E - REMOVER VENDA                                            |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| R - RETORNAR                                                    |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            escolha = Console.ReadLine().ToUpper();
        }

        public void ListarVendas()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                  CONSULTA DE TODAS AS VENDAS                    |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            var repo = new RepositorioVenda();
            var listaVendas = repo.ObterTodos();
            foreach (var item in listaVendas)
            {
                Console.WriteLine(item);
            }
            Console.Write("| R - RETORNAR: ");
            string escolhaSair = Console.ReadLine().ToUpper();
            if (escolhaSair == "R") { ApresentarSubMenu(); }
        }

        public void ApresentarVendaProcuraNome()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                       CONSULTA DA VENDA                         |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (testado)
            {
                Console.WriteLine("| Nome da venda inexistente                                       |");
            }
            Console.Write("| DIGITE O NOME DA VENDA OU RETORNE (R): ");
            string nome = Console.ReadLine();
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (nome.ToUpper() == "R") { MostrarSubMenu(); }
            var repo = new RepositorioArtigo();
            var obtido = repo.ObterPorNome(nome);
            if (obtido == null) { testado = true; }
            else
            {
                Console.WriteLine("|               ID: " + obtido.Identificador);
                Console.WriteLine("|            Ativo: " + obtido.Ativo);
                Console.WriteLine("|             Nome: " + obtido.Nome);
                Console.WriteLine("|          Criação: " + obtido.DataCriacao);
                Console.WriteLine("| Última Alteração: " + obtido.DataAlteracao);
                Console.WriteLine("+-----------------------------------------------------------------+");
                Console.Write("| R - RETORNAR: ");
                string escolhaSair = Console.ReadLine().ToUpper();
                if (escolhaSair == "R") { ApresentarSubMenu(); }
            }
        }

        
    }
}
