using ExercicioHeranca;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nConta Corrente: Número: 101 Titular: Jayanne");
        Conta conta = new();
        conta.Numero = 101;
        conta.Titular = "Jayanne";

        Console.WriteLine("Despositando o R$1.000,00");
        conta.Depositar(1000);
        Console.WriteLine($"Saldo da conta: {conta.Saldo.ToString("c")}");
        Console.WriteLine("Sacando R$100,00");
        conta.Sacar(100);
        Console.WriteLine($"Saldo da conta: " + conta.Saldo.ToString("c"));
        Console.WriteLine("\nSacando R$ 2.000,00");
        conta.Sacar(2000);
        Console.WriteLine($"Saldo da conta: {conta.Saldo.ToString("c")}");

        Console.ReadKey();

        Console.WriteLine("\nConta Poupança: Numero: 102 Titular: Samarah");
        ContaPoupanca contaPoupanca = new();
        contaPoupanca.Numero = 102;
        contaPoupanca.Titular = "Samarah";
        Console.WriteLine("Despositando o R$1000,00");
        contaPoupanca.Depositar(1000);
        Console.WriteLine($"Saldo da Conta Poupanca: {contaPoupanca.Saldo.ToString("c")}");
        Console.WriteLine("Sacando R$100,00");
        contaPoupanca.Sacar(100);
        Console.WriteLine($"Saldo da Conta Poupanca: {contaPoupanca.Saldo.ToString("c")}");
        Console.WriteLine("\nSacando R$ 2.000,00");
        contaPoupanca.Sacar(2000);
        Console.WriteLine($"Saldo da conta poupança: " + contaPoupanca.Saldo.ToString("c"));


        Console.ReadKey();

        Console.WriteLine("\nConta Poupança: Numero: 103 Titular: Jacson");
        ContaInvestimento contaInvestimento = new();
        contaInvestimento.Numero = 103;
        contaInvestimento.Titular = "Jacson";
        Console.WriteLine("Despositando o R$1000,00");
        contaInvestimento.Depositar(1000);
        Console.WriteLine($"Saldo da Conta Poupanca: {contaInvestimento.Saldo.ToString("c")}");
        Console.WriteLine("Sacando R$100,00");
        contaInvestimento.Sacar(100);
        Console.WriteLine($"Saldo da Conta Poupanca: {contaInvestimento.Saldo.ToString("c")}");

        Console.WriteLine("\nSacando R$ 2.000,00");
        contaInvestimento.Sacar(2000);
        Console.WriteLine($"Saldo da conta investimento: " + contaInvestimento.Saldo.ToString("c"));

        Console.ReadKey();
    }
}