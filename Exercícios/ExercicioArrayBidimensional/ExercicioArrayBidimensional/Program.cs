internal class Program
{
    private static void Main(string[] args)
    {
        string[,] alunos = new string[2, 5];

        for (int i = 0; i < alunos.GetLength(0); i++)
        {
            for (int j = 0; j < alunos.GetLength(1); j++)
            {
                Console.WriteLine($"Digite seu nome:[{i},{j}] ");
                alunos[i, j] = Console.ReadLine();
            }

        }

        Console.WriteLine("Exibindo..");

        for (int i = 0; i < alunos.GetLength(0); i++)
            for (int j = 0; j < alunos.GetLength(1); j++)
                Console.WriteLine($"[{i},{j}]:{alunos[i, j]}");
    }
}