using Projeto.DAL.Model;
using Projeto.Lib.Repositorios;
using System;

namespace Projeto.ConsoleApp
{
    public class SubMenu4
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
                    case "4A":
                        ListarClientes();
                        break;
                    case "4B":
                        ApresentarClienteProcuraNome();
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
            Console.WriteLine("| 4 - GESTÃO DE CLIENTES                                          |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   4A - LISTAR TODOS OS CLIENTES                                 |");
            Console.WriteLine("|   4B - OBTER DADOS DO CLIENTE (PROCURA POR NOME)                |");
            Console.WriteLine("|   4C - CRIAR NOVO CLIENTE                                       |");
            Console.WriteLine("|   4D - ALTERAR DADOS DO CLIENTE                                 |");
            Console.WriteLine("|   4E - REMOVER CLIENTE                                          |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| R - RETORNAR                                                    |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            escolha = Console.ReadLine().ToUpper();
        }

        public void ListarClientes()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                  CONSULTA DE TODOS OS CLIENTES                  |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            var repo = new RepositorioCliente();
            var lista = repo.ObterTodos();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.Write("| R - RETORNAR: ");
            string escolhaSair = Console.ReadLine().ToUpper();
            if (escolhaSair == "R") { ApresentarSubMenu(); }
        }
       
        public void ApresentarClienteProcuraNome()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                      CONSULTA DE CLIENTE                        |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (testado)
            {
                Console.WriteLine("| Nome de cliente inexistente                                     |");
            }
            Console.Write("| DIGITE O NOME DO CLIENTE OU RETORNE (R): ");
            string nome = Console.ReadLine();
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (nome.ToUpper() == "R") { MostrarSubMenu(); }
            var repo = new RepositorioCliente();
            var obtido = repo.ObterPorNome(nome);
            if(obtido == null) { testado = true; }
            else
            {
                Console.WriteLine("|               ID: " + obtido.Id);
                Console.WriteLine("|            Ativo: " + obtido.Ativo);
                Console.WriteLine("|             Nome: " + obtido.Nome);
                Console.WriteLine("|  Data Nascimento: " + obtido.DataNascimento);
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
