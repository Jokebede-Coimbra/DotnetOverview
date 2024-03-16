using ExercicioPOO4;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa[] pessoas = new Pessoa[3];

        for (int i = 0; i < pessoas.Length; i++)
        {
            if (i is 0)
            {
                Console.WriteLine("Informe  o nome do professor");
                pessoas[i] = new Professor(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Informe  o nome do aluno");
                pessoas[i] = new Aluno(Console.ReadLine());
            }

        }

        Console.WriteLine("\nExecutando métodos:");

        foreach (var pessoa in pessoas)
        {
            Console.WriteLine(pessoa);
            if (pessoa is Aluno)
            {
                ((Aluno)pessoa).Estudar();
            }
            else if (pessoa is Professor)
            {
                ((Professor)pessoa).Explicar();
            }
        }
    }
}