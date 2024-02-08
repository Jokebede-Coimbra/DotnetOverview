using ExercicioListaII;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Aluno> alunos = FonteDados.GetAlunos();


        ExibeAlunos(alunos);

        var bia = new Aluno { Nome = "Bia", Nota = 7.75 };
        var mario = new Aluno { Nome = "Mario", Nota = 8.95 };
        alunos.Add(bia);
        alunos.Add(mario);

        ExibeAlunos(alunos);

        // Removendo da lista
        var procurarAluno = alunos.Find(x => x.Nome.Equals("Pedro"));
        alunos.Remove(procurarAluno);
        ExibeAlunos(alunos);

        // Ordenação
        // alunos.Sort();
        var listaOrdenada = alunos.OrderBy(x => x.Nome).ToList();
        ExibeAlunos(listaOrdenada);


        Console.WriteLine("\nLista de alunos com a nota >= 8\n");
        var alunosNotaOito = alunos.FindAll(x => x.Nota >= 8);
        foreach (var n in alunosNotaOito)
        {
            Console.WriteLine($"{n.Nome} - {n.Nota}");
        }

    }

    static void ExibeAlunos(List<Aluno> alunos)
    {
        Console.WriteLine("\nLista de alunos\n");
        Console.WriteLine("\nNome \tNota");

        double soma = 0.0;
        foreach (var nota in alunos)
        {
            Console.WriteLine($"{nota.Nome} - {nota.Nota}");
            soma += nota.Nota;


        }
        double media = soma / alunos.Count();
        Console.WriteLine($"A média das notas: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Total de alunos: {alunos.Count}");
    }
}