using ExercicioMembrosEstaticos;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        

        Console.WriteLine("Qual é a cotação do dólar? ");
        double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Quantos dólares você vai comprar? ");
        double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double result = ConversorDeMoedas.DolarParaReal(cotacao, qtd);

        Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

    }
}