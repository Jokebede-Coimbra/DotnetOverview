using Encapsulamento;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        Produto produto = new Produto("TV", 500.00, 10);
        produto.SetNome("Notebook");

        Console.WriteLine(produto.GetNome());
        Console.WriteLine(produto.GetQuantidade());
    }
}