using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTesteER2UC12;

namespace TestMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparação
            double primeiroNumero = 1;
            double segundoNumero = 1;
            double resultadoCorreto = 2;

            //Act - Ação
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);

            //Assert - Verificação
            Assert.AreEqual(resultadoCorreto, resultado);

        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 2)]
        public void SomarDoisNumerosLista(double primeiroNumero, double segundoNumero, double resultadoCorreto) 
        {
            //Act - Ação
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);

            //Assert - Verificação
            Assert.AreEqual(resultadoCorreto, resultado);

        }
    }
}