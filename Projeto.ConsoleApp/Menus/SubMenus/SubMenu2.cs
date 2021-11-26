using Projeto.DAL.Repositorios;
using System;
using System.Text;

namespace Projeto.ConsoleApp
{
    public class SubMenu2
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
                    case "2A":
                        ListarArtigos();
                        break;
                    case "2B":
                        ApresentarArtigoProcuraNome();
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
            Console.WriteLine("| 2 - GESTÃO DE ARTIGOS                                           |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   2A - LISTAR TODOS OS ARTIGOS                                  |");
            Console.WriteLine("|   2B - OBTER DADOS DO ARTIGO (PROCURA POR NOME)                 |");
            Console.WriteLine("|   2C - CRIAR NOVO ARTIGO                                        |");
            Console.WriteLine("|   2D - ALTERAR DADOS DO ARTIGO                                  |");
            Console.WriteLine("|   2E - REMOVER ARTIGO                                           |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| R - RETORNAR                                                    |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            escolha = Console.ReadLine().ToUpper();
        }

        public void ListarArtigos()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                  CONSULTA DE TODOS OS ARTIGOS                   |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            var repo = new RepositorioArtigo();
            var lista = repo.ObterTodos();
            foreach (var item in lista)
            {
                Console.OutputEncoding = Encoding.UTF8;  //Utilizado para reconhecer o símbolo €
                Console.WriteLine(item);
            }
            Console.Write("| R - RETORNAR: ");
            string escolhaSair = Console.ReadLine().ToUpper();
            if (escolhaSair == "R") { ApresentarSubMenu(); }
        }
       
        public void ApresentarArtigoProcuraNome()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                      CONSULTA DO ARTIGO                         |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (testado)
            {
                Console.WriteLine("| Nome de artigo inexistente                                      |");
            }
            Console.Write("| DIGITE O NOME DO ARTIGO OU RETORNE (R): ");
            string nome = Console.ReadLine();
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (nome.ToUpper() == "R") { MostrarSubMenu(); }
            var repo = new RepositorioArtigo();
            var obtido = repo.ObterPorNome(nome);
            if(obtido == null) { testado = true; }
            else
            {
                Console.WriteLine("|               ID: " + obtido.Id);
                Console.WriteLine("|            Ativo: " + obtido.Ativo);
                Console.WriteLine("|             Nome: " + obtido.Nome);
                Console.WriteLine("|        Categoria: " + obtido.CategoriaArtigo);
                Console.WriteLine("|       Referência: " + obtido.ReferenciaEAN);
                Console.WriteLine("|       Fabricante: " + obtido.Fabricante);
                Console.WriteLine("|  Número de Série: " + obtido.NumeroSerie);
                Console.WriteLine("|       Fornecedor: " + obtido.Fornecedor);
                Console.OutputEncoding = Encoding.UTF8;  //Utilizado para reconhecer o símbolo €
                Console.WriteLine("|   Preço Unitário: € " + obtido.PrecoUnitario);
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
