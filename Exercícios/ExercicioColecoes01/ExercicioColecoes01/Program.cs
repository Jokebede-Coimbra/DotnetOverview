using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] frutas = { "Maça", "Banana", "Laranja","Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora" };
        ExibeFrutas(frutas);
        
       
        Console.WriteLine($"\nQuantidade de elementos: {frutas.Count()}\n");

       
        Console.WriteLine($"A segunda fruta: {frutas[1]}");
        Console.WriteLine($"A penúltima fruta {frutas[8]}");

        Console.WriteLine("\nAlterando..");
        frutas[2] = "Kiwi";
        frutas[9] = "Caqui";
        ExibeFrutas(frutas);

        Console.WriteLine($"\nOrdenando...");
        Array.Sort(frutas);
        foreach( string frut in frutas )
            Console.WriteLine( frut );

        Console.WriteLine($"\nOrdem inversa...");
        Array.Reverse(frutas);
        foreach( string frut in frutas )
            Console.WriteLine( frut );
        
        
            


    }
    static void ExibeFrutas(string[] frutas)
    {
        Console.WriteLine("Listando...\n");
        for (int  i = 0; i < frutas.Length; i++)
        {
            Console.WriteLine(frutas[i]);
        }
    }

}