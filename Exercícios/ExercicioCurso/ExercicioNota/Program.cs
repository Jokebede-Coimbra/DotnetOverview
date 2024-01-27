using ExercicioNota;
using System.Globalization;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        Console.WriteLine("Nome do aluno: ");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine("Digite as três notas do aluno: ");
        for (int i = 0; i < aluno.Notas.Length; i++)
        {
            Console.WriteLine($"Nota {i + 1}: ");
            aluno.Notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        Console.WriteLine("Nota Final = "
            + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

        if (aluno.Aprovado())
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("REPROVADO");
            Console.WriteLine("FALTARAM "
            + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
            + " PONTOS");
        }






    }
}