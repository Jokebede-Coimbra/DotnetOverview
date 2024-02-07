internal class Program
{
    private static void Main(string[] args)
    {
        List<string> frutas = new()
        { 
            "Uva", "Maçã", "Pera", "Abacate", "Laranja", "Morango" 
        };

        // Usando Predicado com uma função
        var fruta1 = frutas.Find(Procura);
        Console.WriteLine($"\nPredicado => {fruta1}");

        // Usando a expressão  lambda
        var fruta2 = frutas.Find(x => x.Contains('P'));
        Console.WriteLine($"\nExpressão lambda => {fruta2}");

        var fruta3 = frutas.FindLast(x => x.Contains('A'));
        Console.WriteLine($"\nFindLast: {fruta3}");

        var fruta4 = frutas.FindIndex(x => x.Contains('L'));
        Console.WriteLine($"\nFindIndex: indice={fruta4} item={frutas[fruta4]}");

        var fruta5 = frutas.FindLastIndex(x => x.Contains('U'));
        Console.WriteLine($"\nFindLastIndex: indice={fruta5} item={frutas[fruta5]}");

        Console.WriteLine($"\nFindAll: ");
        var frutas6 = frutas.FindAll(x => x.Contains('M'));
        foreach (var fruta in frutas)
            Console.WriteLine($"{fruta}");
    }

    static bool Procura(string item)
    {
        return item.Contains('M');
    }
}