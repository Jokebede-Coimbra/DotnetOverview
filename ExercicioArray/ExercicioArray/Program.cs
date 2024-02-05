internal class Program
{
    private static void Main(string[] args)
    {

        string[] nomes = new string[5];
        double[] notas = new double[nomes.Length];

        for (int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine("Informe o nome: ");
            nomes[i] = Console.ReadLine();
            Console.WriteLine("Informe a  nota: ");
            notas[i] = double.Parse(Console.ReadLine());
        }


        Console.WriteLine("\n Exibindo as nomes...");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        Console.WriteLine("\n Exibindo as notas...");
        foreach (double nota in notas)
        {
            Console.WriteLine(nota);
        }
        Console.WriteLine("\n Exibindo a Média...");
        ExibirMedia(notas);


        static void ExibirMedia(double[] notas)
        {
            double soma = 0.0;

            foreach (int nota in notas)
            {
                soma += nota;
            }

            double media = soma / notas.Count();
            Console.WriteLine($"A média das notas: {media}");
        }

    }
}