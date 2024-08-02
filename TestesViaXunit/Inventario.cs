using System.Collections.Generic;

public class Produto
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }
}

public class Inventario
{
    private Dictionary<string, Produto> produtos = new Dictionary<string, Produto>();

    public void AdicionarProduto(string nome, int quantidade)
    {
        if (produtos.ContainsKey(nome))
        {
            produtos[nome].Quantidade += quantidade;
        }
        else
        {
            produtos[nome] = new Produto { Nome = nome, Quantidade = quantidade };
        }
        // Log simples
        System.Console.WriteLine($"Produto: {nome}, Quantidade: {produtos[nome].Quantidade}");
    }

    public int ObterQuantidade(string nome)
    {
        var quantidade = produtos.ContainsKey(nome) ? produtos[nome].Quantidade : 0;
        // Log simples
        System.Console.WriteLine($"ObterQuantidade - Produto: {nome}, Quantidade: {quantidade}");
        return quantidade;
    }
}
