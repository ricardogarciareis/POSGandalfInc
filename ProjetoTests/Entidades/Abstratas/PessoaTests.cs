using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.DAL.Entidades;
using System;

namespace Projeto.Tests.Entidades
{
    [TestClass()]
    public class PessoaTests
    {
        [TestMethod()]
        public void DeveCriarClienteTest()
        {
            //Arrange
            var pessoa = new Cliente();
            pessoa.Nome = "Nome da Pessoa";
            pessoa.DataNascimento = new DateTime(2001, 09, 11);
            pessoa.Morada.Endereco = "Rua do Teste, N.º Teste";
            pessoa.Morada.CodigoPostal = "1234-567";
            pessoa.Morada.Observacoes = "Falar com a vizinha";
            pessoa.Morada.Localidade = "Cidade";
            pessoa.NIF = "123456789";
            pessoa.Telefone = "999888777";

            //Act
            var possuiIdentificadorAtribuido = pessoa.Id != new Guid();
            var possuiDataCriacaoAtribuida = pessoa.DataCriacao != new DateTime();

            //Assert
            Assert.IsNotNull(pessoa);
            Assert.IsInstanceOfType(pessoa, typeof(Pessoa));
            Assert.IsTrue(pessoa.Ativo);
            Assert.IsTrue(possuiIdentificadorAtribuido); //TODO
            Assert.IsTrue(possuiDataCriacaoAtribuida);
        }
    }
}