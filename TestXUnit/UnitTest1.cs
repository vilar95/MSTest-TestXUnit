using ProjetoTesteER2UC12;
using Xunit;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {

            //Arrange - Prepara��o
            double primeiroNumero = 1;
            double segundoNumero = 1;
            double resultadoCorreto = 2;

            //Act - A��o
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);

            //Assert - Verifica��o
            Assert.Equal(resultadoCorreto, resultado);
        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 1, 2)]
        public void SomarDoisNumerosLista(double primeiroNumero, double segundoNumero, double resultadoCorreto)
        {
            //Act - A��o
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);

            //Assert - Verifica��o
            Assert.Equal(resultadoCorreto, resultado);

        }
    }
}