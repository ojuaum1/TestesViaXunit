using Xunit;
using System.Collections.Generic;

public class BibliotecaTests
{
    [Fact]
    public void AdicionarLivro_DeveAdicionarLivroALista()
    {
        // Arrange
        var biblioteca = new Biblioteca();
        var livro = new Livro { Titulo = "Livro A", Autor = "Autor A" };

        // Act
        biblioteca.AdicionarLivro(livro);

        // Assert
        var livros = biblioteca.ObterLivros();
        Assert.Contains(livro, livros);
    }
}
