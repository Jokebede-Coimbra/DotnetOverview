using Exercicio01;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Produto produto = new Produto();

        Console.WriteLine("entre com os dados do produto: ");
        Console.WriteLine("Nome: ");
        produto.Nome = Console.ReadLine();

        Console.WriteLine("Preço: ");
        produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Quantidade no estoque: ");
        produto.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine($"Dados do produto:" + produto);

        Console.WriteLine();
        Console.WriteLine("Digite po número de produtos a ser adicionado no estoque: ");
        int qtd  = int.Parse(Console.ReadLine());
        produto.AdicionarProdutos(qtd);

        Console.WriteLine("Dados atualizados: " + produto);

        Console.WriteLine();
        Console.WriteLine("Digite O número de produtos a ser removido no estoque: ");
        int qtdRemove = int.Parse(Console.ReadLine());
        produto.RemoverProdutos(qtdRemove);

        Console.WriteLine("Dados atualizados: " + produto);
    }
}