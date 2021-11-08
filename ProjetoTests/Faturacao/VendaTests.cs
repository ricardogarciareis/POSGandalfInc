using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Lib.Entidades;
using System.Collections.Generic;

namespace Projeto.Lib.Faturacao.Tests
{
    [TestClass()]
    public class VendaTests
    {
        #region Testes que não utilizam o TestInitializer
        [TestMethod()]
        public void DeveImpedirVendaDeItemSemStockTest()
        {
            //Arrange
            var stock = new Stock
            {
                ListaArtigosParaVenda = new List<Artigo>
                {
                    new Artigo { Nome = "Computador" },
                    new Artigo { Nome = "Computador" },
                    new Artigo { Nome = "Computador" },
                    new Artigo { Nome = "Computador" },
                    new Artigo { Nome = "Smartphone XIAOMI" }
                }
            };

            var venda = new Venda()
            {
                DetalheVenda = new DetalheDeVenda()
                {
                    ListaDeArtigos = new List<Artigo>()
                    {
                        new Artigo { Nome = "Smartphone XIAOMI" },
                        new Artigo { Nome = "Smartphone XIAOMI" }
                    }
                }
            };

            //Act
            var vendaPossivel = stock.ValidarDisponibilidade(venda.DetalheVenda.ListaDeArtigos);

            //Assert
            Assert.IsFalse(vendaPossivel);
        }

        [TestMethod()]
        public void DevePermitirVendaDeItemComStockTest()
        {
            //Arrange
            var stock = new Stock
            {
                ListaArtigosParaVenda = new List<Artigo>
                {
                    new Artigo { Nome = "Computador" },
                    new Artigo { Nome = "Computador" },
                    new Artigo { Nome = "Computador" },
                    new Artigo { Nome = "Computador" },
                    new Artigo { Nome = "Smartphone XIAOMI" },
                    new Artigo { Nome = "Smartphone XIAOMI" }
                }
            };

            var qtdSmartphoneVendidos = 2;
            var qtdComputadoresVendidos = 4;

            var venda = new Venda()
            {
                DetalheVenda = new DetalheDeVenda() { ListaDeArtigos = new List<Artigo>() }
            };

            for (int i = 0; i < qtdSmartphoneVendidos; i++)
            {
                venda.DetalheVenda.ListaDeArtigos.Add(new Artigo { Nome = "Smartphone XIAOMI" });
            }

            for (int i = 0; i < qtdComputadoresVendidos; i++)
            {
                venda.DetalheVenda.ListaDeArtigos.Add(new Artigo { Nome = "Computador" });
            }

            //Act
            var vendaPossivel = stock.ValidarDisponibilidade(venda.DetalheVenda.ListaDeArtigos);

            //Assert
            Assert.IsTrue(vendaPossivel);
        }
        #endregion


        /*********************************************************************************/

        #region Testes que utilizam o TestInitializer
        private Stock stockCentralDeTestes;

        [TestInitialize]
        public void PreparacaoDeTestes()
        {
            stockCentralDeTestes = new Stock
            {
                ListaArtigosParaVenda = new List<Artigo>
                {
                    new Artigo { Nome = "Computador ASUS" },
                    new Artigo { Nome = "Computador ASUS" },
                    new Artigo { Nome = "Impressora HP" },
                    new Artigo { Nome = "Impressora HP" },
                    new Artigo { Nome = "Smartphone XIAOMI" },
                    new Artigo { Nome = "Smartphone XIAOMI" }
                }
            };
        }

        [TestMethod]
        public void ExemploUtilizacaoTesteInitializeImpedirVendaDeItemSemStockTest()
        {
            //Arrange
            var venda = new Venda()
            {
                DetalheVenda = new DetalheDeVenda 
                { 
                    ListaDeArtigos = new List<Artigo>
                    {
                        new Artigo { Nome = "Smartphone XIAOMI" },
                        new Artigo { Nome = "Smartphone XIAOMI" },
                        new Artigo { Nome = "Smartphone XIAOMI" }
                    }
                }
            };

            //Act
            var vendaPossivel = stockCentralDeTestes.ValidarDisponibilidade(venda.DetalheVenda.ListaDeArtigos);

            //Assert
            Assert.IsFalse(vendaPossivel);
        }
        

        [DataTestMethod]
        [DataRow(1, "Smartphone XIAOMI", true)]    //Teste 1
        [DataRow(2, "Smartphone XIAOMI", true)]    //Teste 2
        [DataRow(3, "Smartphone XIAOMI", false)]   //Teste 3
        [DataRow(0, "Smartphone XIAOMI", false)]   //Teste 4
        [DataRow(-1, "Smartphone XIAOMI", false)] //Teste 5
        public void ExemploUtilizacaoTesteDinamicoInitializeImpedirVendaDeItemSemStockTest(int qtd, string nome, bool resultadoEsperado)
        {
            //Arrange
            var venda = new Venda()
            {
                DetalheVenda = new DetalheDeVenda
                {
                    ListaDeArtigos = new List<Artigo>()
                }
            };
            for(int i = 0; i < qtd; i++)
            {
                venda.DetalheVenda.ListaDeArtigos.Add(new Artigo { Nome = nome});
            }

            //Act
            var vendaPossivel = stockCentralDeTestes.ValidarDisponibilidade(venda.DetalheVenda.ListaDeArtigos);

            //Assert
            Assert.AreEqual(resultadoEsperado, vendaPossivel);
        }
        #endregion




    }
}