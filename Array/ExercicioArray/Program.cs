internal class Program
{
    private static void Main(string[] args)
    {
        string[] nomes = { "Ana", "Maria", "Pedro", "João" };

        Console.WriteLine("Exibindo Array original....");
        ExibeArray(nomes);

        Console.WriteLine("\n Invertendo a ordem do Array....");
        Array.Reverse(nomes);
        ExibeArray(nomes);

        Console.WriteLine("\n Ordenando o  Array....");
        Array.Sort(nomes);
        ExibeArray(nomes);

        Console.WriteLine("\n Localizando um item no Array....");
        Console.WriteLine("Informe o nome: ");
        string nome = Console.ReadLine();

        var indice = Array.BinarySearch(nomes, nome);

        if (indice >= 0)
            Console.WriteLine($"\n{nome} foi encontrado com índice = {indice}");
        else
            Console.WriteLine($"\n{nome}: não foi encontrado");


    }
    static void ExibeArray(string[] nomes)
    {
        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }
}
