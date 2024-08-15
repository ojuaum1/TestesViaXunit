# Exercícios de Testes Unitários

Este repositório contém exemplos de testes unitários para métodos comuns em aplicações .NET.

## Exercícios

### Exercício 1: Teste de Gerenciamento de Livros
- **Método:** `AdicionarLivro`
- **Descrição:** Verifica se um livro é adicionado corretamente a uma lista de livros.

- public class Biblioteca
{
    private List<string> livros = new List<string>();

    public void AdicionarLivro(string livro)
    {
        livros.Add(livro);
    }

    public List<string> ObterLivros()
    {
        return livros;
    }
}


Teste Unitário:

public class BibliotecaTests
{
    [Fact]
    public void AdicionarLivro_DeveAdicionarLivroNaLista()
    {
        // Arrange
        var biblioteca = new Biblioteca();
        var livro = "O Senhor dos Anéis";

        // Act
        biblioteca.AdicionarLivro(livro);

        // Assert
        Assert.Contains(livro, biblioteca.ObterLivros());
    }
}


### Exercício 2: Teste de Validação de Email
- **Método:** `ValidarEmail`
- **Descrição:** Verifica se um email é validado corretamente com base na presença de "@" e ".".
- **Atributos:** Utiliza `[InlineData]` e `[Theory]`.
- 
Implementação

public class ValidadorEmail
{
    public bool ValidarEmail(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }
}

Teste Unitário com [InlineData] e [Theory]:

public class ValidadorEmailTests
{
    [Theory]
    [InlineData("teste@dominio.com", true)]
    [InlineData("invalido@dominio", false)]
    [InlineData("semarobase.com", false)]
    public void ValidarEmail_DeveRetornarResultadoCorreto(string email, bool esperado)
    {
        // Arrange
        var validador = new ValidadorEmail();

        // Act
        var resultado = validador.ValidarEmail(email);

        // Assert
        Assert.Equal(esperado, resultado);
    }
}



### Exercício 3: Teste de Conversão de Temperatura
- **Método:** `ConverterCelsiusParaFahrenheit`
- **Descrição:** Verifica se a conversão de Celsius para Fahrenheit é calculada corretamente.

- public class ConversorDeTemperaturaTests
{
    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    [InlineData(-40, -40)]
    public void ConverterCelsiusParaFahrenheit_DeveRetornarCorretamente(double celsius, double fahrenheitEsperado)
    {
        // Arrange
        var conversor = new ConversorDeTemperatura();

        // Act
        var resultado = conversor.ConverterCelsiusParaFahrenheit(celsius);

        // Assert
        Assert.Equal(fahrenheitEsperado, resultado);
    }
}


### Exercício 4: Teste de Controle de Inventário
- **Método:** `AdicionarProduto`
- **Descrição:** Verifica se um produto é adicionado ou se a quantidade é incrementada corretamente no inventário.
- **Método Adicional:** `ObterQuantidade` para verificar a quantidade de um produto no inventário.

public class InventarioTests
{
    [Fact]
    public void AdicionarProduto_DeveAdicionarNovoProdutoOuIncrementarQuantidade()
    {
        // Arrange
        var inventario = new Inventario();
        var produto = new Produto { Nome = "Produto Exemplo", Quantidade = 10 };

        // Act
        inventario.AdicionarProduto(produto);
        inventario.AdicionarProduto(new Produto { Nome = "Produto Exemplo", Quantidade = 5 });

        // Assert
        var produtoNoInventario = inventario.ObterProdutoPorNome("Produto Exemplo");
        Assert.NotNull(produtoNoInventario);
        Assert.Equal(15, produtoNoInventario.Quantidade);
    }
    
    [Fact]
    public void ObterQuantidade_DeveRetornarQuantidadeCorreta()
    {
        // Arrange
        var inventario = new Inventario();
        inventario.AdicionarProduto(new Produto { Nome = "Produto Exemplo", Quantidade = 10 });

        // Act
        var quantidade = inventario.ObterQuantidade("Produto Exemplo");

        // Assert
        Assert.Equal(10, quantidade);
    }
}


## Como Executar os Testes

1. Clone o repositório:
   ```bash
   git clone https://TestesViaXunit.git




