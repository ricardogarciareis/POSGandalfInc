using Projeto.Lib.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.ConsoleApp
{
    public class SubMenu8
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
                    case "8A":
                        ListarLojas();
                        break;
                    case "8B":
                        ApresentarLojaProcuraNome();
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
            Console.WriteLine("| 8 - GESTÃO DE LOJAS                                             |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|   8A - LISTAR TODAS AS LOJAS                                    |");
            Console.WriteLine("|   8B - OBTER DADOS DA LOJA (PROCURA POR NOME)                   |");
            Console.WriteLine("|   8C - CRIAR NOVA LOJA                                          |");
            Console.WriteLine("|   8D - ALTERAR DADOS DA LOJA                                    |");
            Console.WriteLine("|   8E - REMOVER LOJA                                             |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("| R - RETORNAR                                                    |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.Write("| ESCOLHA UMA OPÇÃO: ");
            escolha = Console.ReadLine().ToUpper();
        }

        public void ListarLojas()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                   CONSULTA DE TODAS AS LOJAS                    |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            var repo = new RepositorioLoja();
            var lista = repo.ObterTodos();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.Write("| R - RETORNAR: ");
            string escolhaSair = Console.ReadLine().ToUpper();
            if (escolhaSair == "R") { ApresentarSubMenu(); }
        }
       
        public void ApresentarLojaProcuraNome()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------------------+");
            Console.WriteLine("|                        CONSULTA DE LOJA                         |");
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (testado)
            {
                Console.WriteLine("| Nome de loja inexistente                                        |");
            }
            Console.Write("| DIGITE O NOME DA LOJA OU RETORNE (R): ");
            string nome = Console.ReadLine();
            Console.WriteLine("+-----------------------------------------------------------------+");
            if (nome.ToUpper() == "R") { MostrarSubMenu(); }
            var repo = new RepositorioLoja();
            var obtido = repo.ObterPorNome(nome);
            if(obtido == null) { testado = true; }
            else
            {
                Console.WriteLine("|               ID: " + obtido.Identificador);
                Console.WriteLine("|            Ativo: " + obtido.Ativo);
                Console.WriteLine("|             Nome: " + obtido.Nome);
                Console.WriteLine("|            Local: " + obtido.Local);
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
