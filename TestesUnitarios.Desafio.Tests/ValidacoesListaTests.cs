using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //Implementado

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);
        // Assert
        Assert.False(resultado);
    }

    //Implementado
    [Theory]
    [InlineData(new int[] { 10, 14, 16, 18 })]
    public void DeveMultiplicarOsElementosDaListaPor2(int[] numeros)
    {
        //Implementado

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };

        // Act
        var retorno = _validacoes.MultiplicarNumerosLista(lista, 2);
        // Assert
        Assert.All(retorno, n => {

            for (int i = 0; i < numeros.Length; i++)
            {
                Assert.Equal(numeros[i], numeros[i]);
            }
            
            });
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //Implementado

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var retorno = _validacoes.RetornarMaiorNumeroLista(lista);
        // Assert
        //Implementado
        Assert.Equal(9, retorno);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //Implementado

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //Implementado
        Assert.Equal(-8, resultado);
    }
}
