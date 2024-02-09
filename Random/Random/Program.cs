internal class Program
{
    private static void Main(string[] args)
    {
       
        Console.WriteLine("Sorteio da MegaSena\n");

        Random random = new Random();

        int[] numerosSorteados = new int[6];

        for (int i = 0; i< numerosSorteados.Length; i++)
        {
            int numeroAleatorio;
            do
            {
                numeroAleatorio = random.Next(1, 61);
            }
            while (numerosSorteados.Contains(numeroAleatorio));

            numerosSorteados[i] = numeroAleatorio;
        }
        
        Array.Sort(numerosSorteados);
        Console.WriteLine("Número Sorteados\n");
        Console.WriteLine(string.Join(" ", numerosSorteados));

    }
}