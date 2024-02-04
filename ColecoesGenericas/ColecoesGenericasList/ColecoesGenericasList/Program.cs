
internal class Program
{
    private static void Main(string[] args)
    {
        // Declarar uma coleção do tipo List<T>

        List<string> list;
        list = new List<string>();

        List<int> lista1 = new List<int>(); 

        var lista2 = new List<float>();

        List<double> lista3 = new();

        List<string> nomes = new();
        nomes.Add("Maria");
        nomes.Add("Alex");

        var lista4 = new List<string>()
        {
            "Paula", "Raquel", "Jacilene"
        };

        Console.WriteLine("===============================");

        var lista = new List<string>() { "Paula", "Raquel", "Jacilene", "Maria" };

        string[] array1 = { "Alex", "Bob", "Marcos" };

        lista.Add("Marta");
        lista.Insert(0, "José");
        lista.InsertRange(1, array1);


        foreach (var item in lista)
            Console.WriteLine(item);

        Console.WriteLine(lista.Count + " itens");

        Console.WriteLine("===============================");
        var numeros = new List<int>() { 9, 5, 4, 3, 2, 1, 0, 6, 7 };

        numeros.Remove(5);  
        numeros.RemoveAt(3); 
        numeros.RemoveRange(0, 3); 

        foreach (var item in numeros)
            Console.WriteLine(item);
        Console.WriteLine(numeros.Count + " itens");

        Console.WriteLine("===============================");
        var nomes2 = new List<string>()
        {
            "Paula", "Raquel", "Jacilene"
        };

        var res = nomes2.Contains("Raquel");
        Console.WriteLine(res);

        Console.WriteLine("===============================");
        var nomes3 = new List<string>()
        {
            "Paula", "Raquel", "Jacilene"
        };

        ExibirLista(nomes3);

        nomes3.Sort();

        ExibirLista(nomes3);

        nomes3.Clear();
        ExibirLista(nomes3);
        Console.WriteLine("Fim");

    }

    private static void ExibirLista(List<string> nomes3)
    {
        Console.WriteLine();
        foreach (var nome in nomes3)
            Console.WriteLine(nome);
    }
}