using ExercicioPOO2;

internal class Program
{
    private static void Main(string[] args)
    {
        {
            LivroFotos livroFotos = new LivroFotos();
            Console.WriteLine($"Criando um Livro de fotos com : {livroFotos.GetNumeroPaginas()}");

            LivroFotos livroFotos2 = new LivroFotos(24);
            Console.Write("Criando um Livro de fotos com : ");            Console.WriteLine(livroFotos2.GetNumeroPaginas());

            SuperLivroFotos super = new SuperLivroFotos();
            Console.Write("Criando um Livro de fotos com : ");
            Console.WriteLine(super.GetNumeroPaginas());



        }
    }
}