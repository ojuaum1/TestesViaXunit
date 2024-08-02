public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
}

public class Biblioteca
{
    private List<Livro> livros = new List<Livro>();

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public List<Livro> ObterLivros()
    {
        return livros;
    }
}
