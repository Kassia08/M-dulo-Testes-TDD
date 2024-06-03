using System.ComponentModel;
using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    public CalculadoraImp construirClasse()
    {
        string data = "02/06/2024";
        CalculadoraImp calc = new CalculadoraImp("02/06/2024");

        return calc;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestSomar(int var1, int var2, int resultado)
    {
        CalculadoraImp calc = construirClasse();

        int resultadoCalculadora = calc.somar(var1, var2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TestMultiplicar(int var1, int var2, int resultado)
    {
        CalculadoraImp calc = construirClasse();

        int resultadoCalculadora = calc.multiplicar(var1, var2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (5, 2, 3)]
    [InlineData (6, 5, 1)]
    public void TestSubtrair(int var1, int var2, int resultado)
    {
        CalculadoraImp calc = construirClasse();

        int resultadoCalculadora = calc.subtrair(var1, var2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (20, 5, 4)]
    public void TestDividir(int var1, int var2, int resultado)
    {
        CalculadoraImp calc = construirClasse();

        int resultadoCalculadora = calc.dividir(var1, var2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDividirPorZero()
    {
        CalculadoraImp calc = construirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.dividir(3,0)
        );
    }

    [Fact]
    public void TestarHistorico()
    {
        CalculadoraImp calc = construirClasse();

        calc.somar(1, 2);
        calc.somar(2, 8);
        calc.somar(3, 7);
        calc.somar(4, 1);

        var lista = calc.historico();

        Assert.NotEmpty(calc.historico());
        Assert.Equal(3, lista.Count);
    }
}

