using System;
using Xunit;
using CalculadoraApp; 

namespace CalculadoraApp.Tests
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calculadora;

        public CalculadoraTests()
        {
            _calculadora = new Calculadora();
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -1, -2)]
        [InlineData(0, 0, 0)]
        public void Adicionar_DeveRetornarSomaCorreta(double a, double b, double resultadoEsperado)
        {
            // Act
            double resultado = _calculadora.Adicionar(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(-1, -1, 0)]
        [InlineData(0, 0, 0)]
        public void Subtrair_DeveRetornarDiferencaCorreta(double a, double b, double resultadoEsperado)
        {
            // Act
            double resultado = _calculadora.Subtrair(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-1, -1, 1)]
        [InlineData(0, 5, 0)]
        public void Multiplicar_DeveRetornarProdutoCorreto(double a, double b, double resultadoEsperado)
        {
            // Act
            double resultado = _calculadora.Multiplicar(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(1, 1, 1)]
        [InlineData(-10, -2, 5)]
        public void Dividir_DeveRetornarQuocienteCorreto(double a, double b, double resultadoEsperado)
        {
            // Act
            double resultado = _calculadora.Dividir(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Dividir_DeveLancarExcecaoQuandoDividirPorZero()
        {
            // Act & Assert
            var exception = Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(5, 0));
            Assert.Equal("Divisão por zero!", exception.Message);
        }
    }
}
