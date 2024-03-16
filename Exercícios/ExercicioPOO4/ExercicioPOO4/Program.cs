using ExercicioPOO4;

internal class Program
{
    private static void Main(string[] args)
    {
        int total = 3;
        Pessoa[] pessoas = new Pessoa[total];

        for (int i = 0; i < pessoas.Length; i++)
        {
            Console.WriteLine($"Informe o nome {i + 1}: ");
            pessoas[i] = new Pessoa(Console.ReadLine());
        }

        /* for (int i = 0; i < pessoas.Length; i++)
         {
             Console.WriteLine( pessoas[i]);

         }*/

        foreach (var pessoa in pessoas)
        {
            Console.WriteLine("\n" + pessoa);


        }


    }
}