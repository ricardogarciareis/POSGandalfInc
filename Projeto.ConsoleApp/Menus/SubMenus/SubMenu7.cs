using System;

namespace Projeto.ConsoleApp
{
    public class SubMenu7
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
                    case "7A":
                        ListarPontosVenda();
                        break;
                    case "7B":
                        ApresentarPontoVendaProcuraNome();
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
            Console.WriteLine("| 7 - GESTÃO DE PONTOS DE VENDA                                   |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   7A - LISTAR TODOS OS PONTOS DE VENDA                          |");
            Console.WriteLine("|   7B - OBTER DADOS DO PONTO DE VENDA (PROCURA POR NOME)         |");
            Console.WriteLine("|   7C - CRIAR NOVO PONTO DE VENDA                                |");
            Console.WriteLine("|   7D - ALTERAR DADOS DO PONTO DE VENDA                          |");
            Console.WriteLine("|   7E - REMOVER PONTO DE VENDA                                   |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| R - RETORNAR                                                    |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            escolha = Console.ReadLine().ToUpper();
        }

        public void ListarPontosVenda()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|              CONSULTA DE TODOS OS PONTOS DE VENDA               |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            //var repo = new RepositorioPontoDeVenda();
            //var lista = repo.ObterTodos();
            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item);
            //}
            Console.Write("| R - RETORNAR: ");
            string escolhaSair = Console.ReadLine().ToUpper();
            if (escolhaSair == "R") { ApresentarSubMenu(); }
        }
       
        public void ApresentarPontoVendaProcuraNome()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                   CONSULTA DE PONTO DE VENDA                    |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (testado)
            {
                Console.WriteLine("| Nome de ponto de venda inexistente                              |");
            }
            Console.Write("| DIGITE O NOME DO PONTO DE VENDA OU RETORNE (R): ");
            string nome = Console.ReadLine();
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (nome.ToUpper() == "R") { MostrarSubMenu(); }
            //var repo = new RepositorioPontoDeVenda();
            //var obtido = repo.ObterPorNome(nome);
            //if(obtido == null) { testado = true; }
            else
            {
                //Console.WriteLine("|               ID: " + obtido.Identificador);
                //Console.WriteLine("|            Ativo: " + obtido.Ativo);
                //Console.WriteLine("|             Nome: " + obtido.Nome);
                //Console.WriteLine("|            Email: " + obtido.Email);
                //Console.WriteLine("|         Password: " + obtido.Password);
                //Console.WriteLine("|          Criação: " + obtido.DataCriacao);
                //Console.WriteLine("| Última Alteração: " + obtido.DataAlteracao);
                Console.WriteLine("+-----------------------------------------------------------------+");
                Console.Write("| R - RETORNAR: ");
                string escolhaSair = Console.ReadLine().ToUpper();
                if (escolhaSair == "R") { ApresentarSubMenu(); }
            }
        }
        

    }
}
