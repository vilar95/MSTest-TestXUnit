using ProjetoTesteER2UC12;
using Xunit;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {

            //Arrange - Preparação
            double primeiroNumero = 1;
            double segundoNumero = 1;
            double resultadoCorreto = 2;

            //Act - Ação
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);

            //Assert - Verificação
            Assert.Equal(resultadoCorreto, resultado);
        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 1, 2)]
        public void SomarDoisNumerosLista(double primeiroNumero, double segundoNumero, double resultadoCorreto)
        {
            //Act - Ação
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);

            //Assert - Verificação
            Assert.Equal(resultadoCorreto, resultado);

        }
    }
}