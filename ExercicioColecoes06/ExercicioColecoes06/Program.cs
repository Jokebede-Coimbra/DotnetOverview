using ExercicioColecoes06;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno alunos = new Aluno();
        alunos[1] = "Jayanne";
        alunos[2] = "Josué";
        alunos[3] = "Samarah";


        Console.WriteLine(alunos[1]);
        Console.WriteLine(alunos[2]);
        Console.WriteLine(alunos[3]);

    }

 
}