using Xunit;

public class InventarioTests
{
    [Fact]
    public void AdicionarProduto_DeveAdicionarNovoProduto()
    {
        // Arrange
        var inventario = new Inventario(); 

        // Act
        inventario.AdicionarProduto("Produto A", 10);

        // Assert
        var quantidade = inventario.ObterQuantidade("Produto A");
        Assert.Equal(10, quantidade);
    }

    [Fact]
    public void AdicionarProduto_DeveIncrementarQuantidadeSeProdutoExistir()
    {
        // Arrange
        var inventario = new Inventario();
        inventario.AdicionarProduto("Produto A", 10);

        // Act
        inventario.AdicionarProduto("Produto A", 5);

        // Assert
        var quantidade = inventario.ObterQuantidade("Produto A");
        Assert.Equal(15, quantidade);
    }

    [Fact]
    public void ObterQuantidade_DeveRetornarZeroSeProdutoNaoExistir()
    {
        // Arrange
        var inventario = new Inventario(); 

        // Act
        var quantidade = inventario.ObterQuantidade("Produto Inexistente");

        // Assert
        Assert.Equal(0, quantidade);
    }
}
