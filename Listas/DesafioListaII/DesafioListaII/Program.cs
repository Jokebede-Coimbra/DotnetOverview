internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Digite a quantidade de números para calcular a média");
        int quantidadeNumeros = int.Parse(Console.ReadLine());

        List<double> numeros = ObterNumeros(quantidadeNumeros);


        Console.WriteLine("Exibindo média...");
        CalcularMedia(numeros);
        

        static List<double> ObterNumeros(int quantidade)
        {
            List<double> numeros = new List<double>();

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Numéro: {i}");
                double numero = double.Parse(Console.ReadLine());
                numeros.Add(numero);
            }
            return numeros;
        }

        static void CalcularMedia(List<double> numeros)
        {
            double soma = 0;

            foreach (double n in numeros)
            {
                soma += n;
            }
            double media = soma/numeros.Count;

            Console.WriteLine($"A média dos números: {media}");

        }
    }
}