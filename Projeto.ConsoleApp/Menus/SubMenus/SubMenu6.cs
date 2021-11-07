using Projeto.Lib.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.ConsoleApp
{
    public class SubMenu6
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
                    case "6A":
                        ListarUtilizadores();
                        break;
                    case "6B":
                        ApresentarUtilizadorProcuraNome();
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
            Console.WriteLine("| 6 - GESTÃO DE UTILIZADORES                                      |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   6A - LISTAR TODOS OS UTILIZADORES                             |");
            Console.WriteLine("|   6B - OBTER DADOS DO UTILIZADOR (PROCURA POR NOME)             |");
            Console.WriteLine("|   6C - CRIAR NOVO UTILIZADOR                                    |");
            Console.WriteLine("|   6D - ALTERAR DADOS DO UTILIZADOR                              |");
            Console.WriteLine("|   6E - REMOVER UTILIZADOR                                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| R - RETORNAR                                                    |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            escolha = Console.ReadLine().ToUpper();
        }

        public void ListarUtilizadores()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                CONSULTA DE TODOS OS UTILIZADORES                |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            var repo = new RepositorioUtilizador();
            var lista = repo.ObterTodos();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.Write("| R - RETORNAR: ");
            string escolhaSair = Console.ReadLine().ToUpper();
            if (escolhaSair == "R") { ApresentarSubMenu(); }
        }
       
        public void ApresentarUtilizadorProcuraNome()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                     CONSULTA DE UTILIZADOR                      |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (testado)
            {
                Console.WriteLine("| Nome de utilizador inexistente                                  |");
            }
            Console.Write("| DIGITE O NOME DO UTILIZADOR OU RETORNE (R): ");
            string nome = Console.ReadLine();
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (nome.ToUpper() == "R") { MostrarSubMenu(); }
            var repo = new RepositorioUtilizador();
            var obtido = repo.ObterPorNome(nome);
            if(obtido == null) { testado = true; }
            else
            {
                Console.WriteLine("|               ID: " + obtido.Identificador);
                Console.WriteLine("|            Ativo: " + obtido.Ativo);
                Console.WriteLine("|             Nome: " + obtido.Nome);
                Console.WriteLine("|            Email: " + obtido.Email);
                Console.WriteLine("|         Password: " + obtido.Password);
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
