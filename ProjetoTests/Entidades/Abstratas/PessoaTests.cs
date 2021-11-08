using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Projeto.Lib.Entidades.Tests
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
            pessoa.MoradaPessoa.Endereco = "Rua do Teste, N.º Teste";
            pessoa.MoradaPessoa.CodigoPostal = "1234-567";
            pessoa.MoradaPessoa.Observacoes = "Falar com a vizinha";
            pessoa.MoradaPessoa.Localidade = "Cidade";
            pessoa.NIF = "123456789";
            pessoa.Telefone = "999888777";

            //Act
            var possuiIdentificadorAtribuido = pessoa.Identificador != new Guid();
            var possuiDataCriacaoAtribuida = pessoa.DataCriacao != new DateTime();

            //Assert
            Assert.IsNotNull(pessoa);
            Assert.IsInstanceOfType(pessoa, typeof(Pessoa));
            Assert.IsTrue(pessoa.Ativo);
            Assert.IsTrue(possuiIdentificadorAtribuido);
            Assert.IsTrue(possuiDataCriacaoAtribuida);
        }
    }
}