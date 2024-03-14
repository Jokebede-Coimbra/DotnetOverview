using ExercicioPOO3;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa[] pessoas = new Pessoa[3];


        for (int i = 0; i < pessoas.Length; i++)
        {
            if (i is 0) 
            { 
            Console.WriteLine("Informe o nome do Professor");
            pessoas[i] = new Professor(Console.ReadLine());

            }
            else
            {
            Console.WriteLine("Informe o nome do Aluno: ");
            pessoas[i] = new Aluno(Console.ReadLine());

            }
        }

        for (int i = 0; i < pessoas.Length; i++)
        {
            if (i is 0)
            {
                Console.WriteLine("Professor...");
               ((Professor)pessoas[i]).Explicar();
            }
            else
            {
                Console.WriteLine("Aluno.. ");
                ((Aluno)pessoas[i]).Estudar();

            }
        }


    }
}