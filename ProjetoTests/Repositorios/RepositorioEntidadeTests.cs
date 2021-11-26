using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.DAL.Entidades;
using Projeto.DAL.Repositorios;
using System;

namespace Projeto.Tests.Repositorios
{
    [TestClass()]
    public class RepositorioEntidadeTests
    {
        #region CreateTest
        [TestMethod()]
        public void DeveCriarEntidadeTest()
        {
            //Arrange
            var repo = new RepositorioEntidade();
            var cliente = new Cliente();
            var loja = new Loja();

            //Act
            repo.Criar(cliente);
            repo.Criar(loja);
            var qtdObjetosNoRepo = repo.ObterTodos().Count;

            //Assert
            Assert.AreEqual(2, qtdObjetosNoRepo);
        }
        #endregion

        #region ReadTest
        [TestMethod()]
        public void DeveObterPorIdentificadorEntidadeTest()
        {
            //Arrange
            var repo = new RepositorioEntidade();
            //https://guidgenerator.com/online-guid-generator.aspx
            var idCliente1 = new Guid("37364cda-ccca-4236-8d41-464ca8d84f04");
            var cliente1 = new Cliente { Id = idCliente1, Nome = "Cliente Procurado" };
            var idCliente2 = new Guid("31f2f22e-0926-403d-8137-11034931d083");
            var cliente2 = new Cliente { Id = idCliente2, Nome = "Cliente Teste" };

            var idLoja1 = new Guid("bdea63d8-01da-47ae-97f9-481acc0109cf");
            var loja1 = new Loja { Id = idLoja1, Nome = "Loja Teste" };
            var idLoja2 = new Guid("8fb6e66c-f5d6-4aa3-9dc8-eb4544569965");
            var loja2 = new Loja { Id = idLoja2, Nome = "Loja Procurada" };

            //Act
            repo.Criar(cliente1);
            repo.Criar(cliente2);
            repo.Criar(loja1);
            repo.Criar(loja2);
            var clienteObtido = repo.ObterPorIdentificador(idCliente1);
            var lojaObtida = repo.ObterPorIdentificador(idLoja2);

            //Assert
            Assert.IsInstanceOfType(clienteObtido, typeof(Cliente));
            Assert.AreEqual("Cliente Procurado", clienteObtido.Nome);
            Assert.IsInstanceOfType(lojaObtida, typeof(Loja));
            Assert.AreEqual("Loja Procurada", lojaObtida.Nome);
            //O método ObterPorNome() da do RepositorioEntidade não busca todas os atributos do objeto Cliente, apenas os atributos do objeto Entidade
        }

        [TestMethod()]
        public void DeveObterPorNomeEntidadeTest()
        {
            //Arrange
            var repo = new RepositorioEntidade();
            var cliente1 = new Cliente { Nome = "Cliente Procurado", Telefone = "911222333", Id = new Guid("37364cda-ccca-4236-8d41-464ca8d84f04") };
            var cliente2 = new Cliente { Nome = "Cliente Teste", Telefone = "900111222", Id = new Guid("31f2f22e-0926-403d-8137-11034931d083") };

            var loja1 = new Loja { Nome = "Loja Teste", Local = "Alfragide", Id = new Guid("bdea63d8-01da-47ae-97f9-481acc0109cf") };
            var loja2 = new Loja { Nome = "Loja Procurada", Local = "Almada", Id = new Guid("8fb6e66c-f5d6-4aa3-9dc8-eb4544569965") };

            //Act
            repo.Criar(cliente1);
            repo.Criar(cliente2);
            repo.Criar(loja1);
            repo.Criar(loja2);
            var clienteObtido = repo.ObterPorNome("Cliente Procurado");
            var lojaObtida = repo.ObterPorNome("Loja Procurada");
            //O método ObterPorNome() da do RepositorioEntidade não busca todas os atributos do objeto Cliente, apenas os atributos do objeto Entidade

            //Assert
            Assert.IsInstanceOfType(clienteObtido, typeof(Cliente));
            Assert.AreEqual(new Guid("37364cda-ccca-4236-8d41-464ca8d84f04"), clienteObtido.Id);
            Assert.IsInstanceOfType(lojaObtida, typeof(Loja));
            Assert.AreEqual(new Guid("8fb6e66c-f5d6-4aa3-9dc8-eb4544569965"), lojaObtida.Id);
        }
        #endregion
    }
}