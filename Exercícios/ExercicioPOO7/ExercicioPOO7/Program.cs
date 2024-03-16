using ExercicioPOO7;

internal class Program
{
    private static void Main(string[] args)
    {
        Forma quadrado = new Quadrado(5.5);
        Forma triangulo = new Triangulo(3.0, 5.0);
        Forma circulo = new Circulo(3.5);

        Console.WriteLine("Fórmulas das áreas");
        Console.WriteLine("Quadrado -> " + quadrado.Area());
        Console.WriteLine("Triangulo -> " + triangulo.Area());
        Console.WriteLine("Circulo -> " + circulo.Area());

        Console.WriteLine("\n ---- Outra solução ------- \n");
        var formas = new List<Forma>()
        {
            new Circulo(3.5),
            new Quadrado(5.5),
            new Triangulo(3.0,5.0)
        };
        foreach (var forma in formas)
        {
            Console.WriteLine(forma.Area());
        }

    }
}