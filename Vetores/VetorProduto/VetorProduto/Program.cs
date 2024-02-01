using System.Diagnostics;
using VetorProduto;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Entre com a quantidade do produto: ");
        int qtd = int.Parse(Console.ReadLine());

        Produto[] vect = new Produto[qtd];

        double sum = 0.0;

        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine("Entre com nome do produto: ");
            string name = (Console.ReadLine());

            Console.WriteLine("Entre com preço do produto: ");
            double price = double.Parse(Console.ReadLine());
            vect[i] = new Produto { Name = name, Price = price };
            sum += vect[i].Price;
        }

        double avg = sum / qtd;

        Console.WriteLine("AVERAGE PRICE = " + avg);

    }
}