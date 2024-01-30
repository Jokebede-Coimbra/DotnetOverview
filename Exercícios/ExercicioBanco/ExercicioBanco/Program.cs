using ExercicioBanco;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Conta conta = new Conta();

        Console.WriteLine("Entre o número da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre o titular da conta: ");
        string titular = (Console.ReadLine());

        Console.WriteLine("Haverá depósito inicial (s/n)? ");
        char resposta = char.Parse(Console.ReadLine());

        if (resposta == 's')
        {
            Console.WriteLine("Entre o valor de depósito inicial: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new Conta(numero, titular, deposito);
        }
        else
        {
            conta = new Conta(numero, titular);
        }

        Console.WriteLine("Dados da conta: ");
        Console.WriteLine(conta);

        Console.WriteLine("Entre um valor para depósito: ");
        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Deposito(quantia);


        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta);

        Console.WriteLine("Entre um valor para saque:  ");
        quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(quantia);

        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(conta);


    }
}