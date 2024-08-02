using Xunit;

public class ConversorDeTemperaturaTests
{
    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    [InlineData(-40, -40)]
    [InlineData(37, 98.6)]
    public void ConverterCelsiusParaFahrenheit_DeveConverterCorretamente(double celsius, double esperado)
    {
        // Arrange
        var conversor = new ConversorDeTemperatura();

        // Act
        var resultado = conversor.ConverterCelsiusParaFahrenheit(celsius);

        // Assert
        Assert.Equal(esperado, resultado, 1);
    }
}
