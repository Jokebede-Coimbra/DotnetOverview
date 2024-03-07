using PolimorfismoII;

internal class Program
{
    private static void Main(string[] args)
    {

        // Tipo de polimorfismo que está usando a sobrecarga de métodos, onde eu tenho
        // métodos com o mesmo nome e parâmetros diferentes.


        Calcular calc = new Calcular();

        Console.WriteLine(calc.Somar(20, 10));

        Console.WriteLine(calc.Somar(20, 10, 30));

    }
}