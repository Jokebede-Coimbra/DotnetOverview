using ClasseAbstrata;

internal class Program
{
    private static void Main(string[] args)
    {
        Quadrado quadrado = new();
        Console.WriteLine(quadrado.Descricao());

        Console.WriteLine("\nInforme a cor da figura: ");
        quadrado.Cor = Console.ReadLine();

        Console.WriteLine("\nInforme o valor do lado do quadrado");
        quadrado.Lado = Convert.ToInt32(Console.ReadLine());


        quadrado.CalcularArea();
        quadrado.CalcularPerimetro();

        Console.WriteLine($"\nÁrea do quadrado: {quadrado.Area} m2");
        Console.WriteLine($"\nPerímetro do quadrado: {quadrado.Perimetro} m");

        Console.WriteLine($"\nO quadrado tem a cor: {quadrado.Cor}");

        Console.ReadKey();
    }
}