internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        bool result = VerificaNumeroPrimo(n);

        if (result)
        {
            Console.WriteLine($"{n} é um número primo.");
        }
        else
        {
            Console.WriteLine($"{n} não é um número primo.");
        }


        static bool VerificaNumeroPrimo(int numero)
        {
            if (numero < 2)
                return false;

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }

            }

            return true;
        }
    }
}
