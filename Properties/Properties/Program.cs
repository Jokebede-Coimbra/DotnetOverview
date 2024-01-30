using Properties;

internal class Program
{
    private static void Main(string[] args)
    {
        Produto produto = new Produto("TV", 500.00, 10);

        produto.Nome = ("Notebook");
      

        Console.WriteLine(produto.Nome);
        Console.WriteLine(produto.Quantidade);
    }
}