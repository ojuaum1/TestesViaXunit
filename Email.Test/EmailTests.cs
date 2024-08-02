using Xunit;

public class ValidadorDeEmailTests
{
    [Theory]
    [InlineData("teste@exemplo.com", true)]
    [InlineData("teste.exemplo.com", false)]
    [InlineData("teste@exemplo", false)]
    [InlineData("teste@.com", false)]
    [InlineData("@exemplo.com", false)]
    [InlineData("teste@exemplo.c", false)]
    [InlineData("teste@exemplo..com", false)]
    [InlineData("", false)]
    [InlineData(null, false)]
    public void ValidarEmail_DeveValidarEmailsCorretamente(string email, bool esperado)
    {
        // Arrange
        var validador = new ValidadorDeEmail();

        // Act
        var resultado = validador.ValidarEmail(email);

        // Assert
        Assert.Equal(esperado, resultado);
    }
}
