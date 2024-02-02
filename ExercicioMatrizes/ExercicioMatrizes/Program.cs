internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entre com a linha: ");
        int linha = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com a coluna: ");
        int coluna = int.Parse(Console.ReadLine());

        int[,] mat = new int[linha, coluna];

        for (int i = 0; i < linha; i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            for (int j = 0; j < coluna; j++)
            {
                mat[i, j] = int.Parse(values[j]);
            }
        }

        Console.WriteLine("Qual a ocorrência? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                if (mat[i, j] == n)
                {
                    Console.WriteLine("Position " + i + "," + j + ":");
                    if (j > 0)
                    {
                        Console.WriteLine("Left: " + mat[i, j - 1]);
                    }
                    if (i > 0)
                    {
                        Console.WriteLine("Up: " + mat[i - 1, j]);
                    }
                    if (j < linha - 1)
                    {
                        Console.WriteLine("Right: " + mat[i, j + 1]);
                    }
                    if (i < coluna - 1)
                    {
                        Console.WriteLine("Down: " + mat[i + 1, j]);
                    }
                }

            }
        }
    }
}