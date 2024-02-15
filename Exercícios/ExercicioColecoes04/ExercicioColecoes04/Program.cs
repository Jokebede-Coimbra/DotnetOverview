using ExercicioColecoes04;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Produto> produtos = new()
        {
            new Produto{Nome = "Clips", Preco = 3.95m },
            new Produto{Nome = "Caneta",Preco = 5.99m },
            new Produto{Nome = "Lápis", Preco = 3.95m },
            new Produto{Nome = "Caderno", Preco = 3.95m},
            new Produto{Nome = "Estojo", Preco = 3.95m}
        };
        Console.WriteLine("Relação de produtos");
        ExibeLista(produtos);

        Console.WriteLine("\nInclua na lista o seguinte produto : Mochila, R$ 22,44 e exiba novamente a lista de produtos");

        var mochila = new Produto { Nome = "Mochila", Preco = 22.44m };
        produtos.Add(mochila);

        ExibeLista(produtos);

        Console.WriteLine("\nOrdene a lista pelo nome do produto e exiba a lista ordenada");
        var listaOrdenada = produtos.OrderBy(p => p.Nome).ToList();
        ExibeLista(produtos);

        Console.WriteLine("\nObtenha e exiba no console os produtos com preço inferior a R$ 5,00");
        var ProdutosMenorCinco = produtos.FindAll(p => p.Preco < 5);
        foreach (var item in ProdutosMenorCinco)
            Console.WriteLine($"{item.Nome} - {item.Preco}");

        Console.WriteLine("\nLocalize na lista o produto com nome Estojo");
        var prod1 = produtos.Find(p => p.Nome.Equals("Estojo"));
        Console.WriteLine($"{prod1.Nome} - {prod1.Preco }");

    }

    static void ExibeLista(List<Produto> prod)
    {
        decimal soma = 0.0m;
        decimal media;

        foreach (var produto in prod)
        {
            Console.WriteLine($"\n{produto.Nome} - {produto.Preco} ");
            soma += produto.Preco;
           
        }
        media = soma / prod.Count();

        Console.WriteLine($"\nA soma total dos preços dos produtos: {soma}");
        Console.WriteLine($"A média do preço dos produtos: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"A quantidade de produtos na lista: {prod.Count}");

    }
}