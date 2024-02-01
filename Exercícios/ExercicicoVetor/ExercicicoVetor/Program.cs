using ExercicicoVetor;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Pensionato[] vect = new Pensionato[10];

        Console.WriteLine("Quantos quartos serão alugados? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Aluguel #{i+1}:");

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Quarto: ");
            int quarto = int.Parse(Console.ReadLine()); 

            vect[quarto] = new Pensionato(nome , email);

        }

        Console.WriteLine("Quartos ocupados: ");
        for (int i = 0; i < 10; i++)
        {
            if (vect[i] != null)
            {
                Console.WriteLine($"{i}: {vect[i]}") ;
            }
        }

    }
}