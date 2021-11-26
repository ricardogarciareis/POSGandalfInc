using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.DAL.Entidades;
using Projeto.DAL.Repositorios;
using System;
using System.Collections.Generic;

namespace Projeto.Tests.Repositorios
{
    [TestClass()]
    public class RepositorioVendaTests
    {
        [TestMethod()]
        public void CalcularTotalPorIdentificadorTest()
        {
            //Arrange
            var repo = new RepositorioVenda();
            var venda = new DAL.Faturacao.Venda
            {
                DetalheVenda = new DAL.Faturacao.DetalheDeVenda()
                {
                    ListaDeArtigos = new List<Artigo>()
                    {
                        new Artigo { Nome = "Artigo 0", NumeroSerie = "1000000.00", PrecoUnitario = 199.90M },
                        new Artigo { Nome = "Artigo 0", NumeroSerie = "1000000.01", PrecoUnitario = 199.90M },
                        new Artigo { Nome = "Artigo 1", NumeroSerie = "1000001.00", PrecoUnitario = 229.90M }
                    }
                },
                Id = new Guid("37364cda-ccca-4236-8d41-464ca8d84f04")
            };
            repo.Criar(venda);
            var totalEsperado = 199.90M + 199.90M + 229.90M;

            //Act
            var totalVenda = repo.CalcularTotalPorIdentificador(new Guid("37364cda-ccca-4236-8d41-464ca8d84f04"));

            //Assert
            Assert.AreEqual(totalEsperado, totalVenda);
            
        }
    }
}