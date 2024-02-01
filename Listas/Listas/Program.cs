using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> list = new List<string>();

        list.Add("Maria");
        list.Add("Alex");
        list.Add("Bob");
        list.Add("Anna");
        list.Insert(1, "Kiko");

        foreach (string item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("List count: " + list.Count);

        // expressão lambda(função anônima)
        string s1 = list.Find(x => x[0] == 'A');
        Console.WriteLine("First 'A' : " + s1);

        string s2 = list.FindLast(x => x[0] == 'A');
        Console.WriteLine("Last 'A' : " + s2);

        int pos1 = list.FindIndex(x => x[0] == 'A');
        Console.WriteLine("First position 'A': " + pos1);

        int pos2 = list.FindLastIndex(x => x[0] == 'A');
        Console.WriteLine("Last position 'A': " + pos2);

        Console.WriteLine("==================Filtro=================");
        List<string> list2 = list.FindAll(x => x.Length == 5);
        foreach (string item in list2)
            Console.WriteLine(item);

        Console.WriteLine("==================Remove===============");
        list.Remove("Kiko");
        foreach (string item in list)
            Console.WriteLine(item);

        Console.WriteLine("===============RemoveRange==============");
        list.RemoveRange(2, 2);
        foreach (string item in list)
            Console.WriteLine(item);

        Console.WriteLine("==================RemoveAt=============");
        list.RemoveAt(1);
        foreach (string item in list)
            Console.WriteLine(item);

        Console.WriteLine("===============RemoveAll===============");
        list.RemoveAll(x => x[0] == 'A');
        foreach (string item in list)
            Console.WriteLine(item);





    }
}