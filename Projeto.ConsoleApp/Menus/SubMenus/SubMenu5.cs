using Projeto.Lib.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.ConsoleApp
{
    public class SubMenu5
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
                    case "5A":
                        ListarFornecedores();
                        break;
                    case "5B":
                        ApresentarFornecedorProcuraNome();
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
            Console.WriteLine("| 5 - GESTÃO DE FORNECEDORES                                      |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   5A - LISTAR TODOS OS FORNECEDORES                             |");
            Console.WriteLine("|   5B - OBTER DADOS DO FORNECEDOR (PROCURA POR NOME)             |");
            Console.WriteLine("|   5C - CRIAR NOVO FORNECEDOR                                    |");
            Console.WriteLine("|   5D - ALTERAR DADOS DO FORNECEDOR                              |");
            Console.WriteLine("|   5E - REMOVER FORNECEDOR                                       |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| R - RETORNAR                                                    |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            escolha = Console.ReadLine().ToUpper();
        }

        public void ListarFornecedores()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                CONSULTA DE TODOS OS FORNECEDORES                |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            var repo = new RepositorioFornecedor();
            var lista = repo.ObterTodos();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.Write("| R - RETORNAR: ");
            string escolhaSair = Console.ReadLine().ToUpper();
            if (escolhaSair == "R") { ApresentarSubMenu(); }
        }
       
        public void ApresentarFornecedorProcuraNome()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                     CONSULTA DE FORNECEDOR                      |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (testado)
            {
                Console.WriteLine("| Nome de fornecedor inexistente                                  |");
            }
            Console.Write("| DIGITE O NOME DO FORNECEDOR OU RETORNE (R): ");
            string nome = Console.ReadLine();
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (nome.ToUpper() == "R") { MostrarSubMenu(); }
            var repo = new RepositorioFornecedor();
            var obtido = repo.ObterPorNome(nome);
            if(obtido == null) { testado = true; }
            else
            {
                Console.WriteLine("|               ID: " + obtido.Identificador);
                Console.WriteLine("|            Ativo: " + obtido.Ativo);
                Console.WriteLine("|             Nome: " + obtido.Nome);
                Console.WriteLine("|        Pontuação: " + obtido.Pontuacao);
                Console.WriteLine("|              NIF: " + obtido.NIF);
                Console.WriteLine("|         Telefone: " + obtido.Telefone);
                Console.WriteLine("|            Email: " + obtido.Email);
                Console.WriteLine("|         Endereço: " + obtido.MoradaPessoa.Endereco);
                Console.WriteLine("|    Código Postal: " + obtido.MoradaPessoa.CodigoPostal);
                Console.WriteLine("|       Localidade: " + obtido.MoradaPessoa.Localidade);
                Console.WriteLine("|      Observações: " + obtido.MoradaPessoa.Observacoes);
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
