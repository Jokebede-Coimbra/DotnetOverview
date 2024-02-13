internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Entre com a quantidade de números: ");
        var numero = int.Parse(Console.ReadLine());

        int[] numeros = new int[numero];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Digite um número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }


        string entrada;
        do
        {
            Console.WriteLine("Qual número deseja encontrar? ");
            entrada = Console.ReadLine();

            if (entrada.ToLower() != "fim")
            {
                int n = int.Parse(entrada);

                var indice = Array.BinarySearch(numeros, n);

                if (indice >= 0)
                {
                    Console.WriteLine($"\n{n} foi encontrado com índice = {indice}");
                }
                else
                {
                    Console.WriteLine($"{n} não foi encontrado.");

                }
            }
        } while (entrada.ToLower() != "fim");

        ExibeArray(numeros);



        static void ExibeArray(int[] numeros)
        {
            foreach (var numero in numeros)
            {
                Console.WriteLine($"\n{numero}");
            }

        }
    }
}