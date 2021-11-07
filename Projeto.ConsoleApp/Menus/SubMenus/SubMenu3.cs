using Projeto.Lib.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.ConsoleApp
{
    public class SubMenu3
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
                    case "3A":
                        ListarCategoriasArtigos();
                        break;
                    case "3B":
                        ApresentarCategoriaArtigoProcuraNome();
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
            Console.WriteLine("| 3 - GESTÃO DE CATEGORIAS DE ARTIGOS                             |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   3A - LISTAR TODAS AS CATEGORIAS DE ARTIGOS                    |");
            Console.WriteLine("|   3B - OBTER DADOS DA CATEGORIA DE ARTIGO (PROCURA POR NOME)    |");
            Console.WriteLine("|   3C - CRIAR NOVA CATEGORIA DE ARTIGO                           |");
            Console.WriteLine("|   3D - ALTERAR DADOS DA CATEGORIA DE ARTIGO                     |");
            Console.WriteLine("|   3E - REMOVER CATEGORIA DE ARTIGO                              |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| R - RETORNAR                                                    |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            escolha = Console.ReadLine().ToUpper();
        }

        public void ListarCategoriasArtigos()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|           CONSULTA DE TODAS AS CATEGORIAS DE ARTIGOS            |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            var repo = new RepositorioCategoriaArtigo();
            var lista = repo.ObterTodos();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.Write("| R - RETORNAR: ");
            string escolhaSair = Console.ReadLine().ToUpper();
            if (escolhaSair == "R") { ApresentarSubMenu(); }
        }
       
        public void ApresentarCategoriaArtigoProcuraNome()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|               CONSULTA DE CATEGORIA DE ARTIGO                   |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (testado)
            {
                Console.WriteLine("| Nome de categoria de artigo inexistente                         |");
            }
            Console.Write("| DIGITE O NOME DA CATEGORIA DE ARTIGO OU RETORNE (R): ");
            string nome = Console.ReadLine();
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (nome.ToUpper() == "R") { MostrarSubMenu(); }
            var repo = new RepositorioCategoriaArtigo();
            var obtido = repo.ObterPorNome(nome);
            if(obtido == null) { testado = true; }
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
