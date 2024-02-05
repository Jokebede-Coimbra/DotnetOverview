internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, int> dict1 = new Dictionary<int, int>();

        var dict2 = new Dictionary<int, int>();
        dict2.Add(1, 201);
        dict2.Add(4, 502);
        dict2.Add(3, 108);

        var dict3 = new Dictionary<int, int>()
        {
            {1, 100 },
            {2, 200 },
            {3, 300 }
        };

        foreach (var dict in dict2)
            Console.WriteLine(dict);


        Console.WriteLine("\n - Incluir elemento com chave(3) duplicada");
        // "Add > Lança exceção

        try
        {
            dict3.Add(3, 303);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.ToString());
        }

        // TryAdd > Retorna True ou False 
        var resultado = dict3.TryAdd(3, 303);
        Console.WriteLine("Elemento foi incluído? " + resultado);

        // ContainsKey
        Console.WriteLine("\n - Incuindo o elemento com chave 7 e valor 700 ");
        if (!dict3.ContainsKey(5))
        {
            dict3.Add(7, 700);
        }
        Console.WriteLine(dict3[7]);

        // ContaisValue
        Console.WriteLine("\n - Usando ContainsValue");
        if (dict3.ContainsValue(700))
        {
            Console.WriteLine("O valor existe no Dicionário.");
        }

        // Alterando o valor
        Console.WriteLine("\n - Alterando o valor do elemento com chave 7");
        if (dict3.ContainsKey(7))
        {
            dict3[7] = 107;
        }
        Console.WriteLine("Valor alterado do item: " + dict3[7]);

        Console.WriteLine("\n Tentando obter elemente com chave(5) inexistente");

        try
        {
            Console.WriteLine(dict3[5]);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.ToString());
        }

        Console.WriteLine("\n - Usando TryGetValue() para chave 5");

        if (dict3.TryGetValue(5, out int valor))
        {
            Console.WriteLine("Valor para a chave 5 = " + valor);
        }
        else
        {
            Console.WriteLine("Chave não encontrada");
        }

        dict3.Add(6, 106);
        dict3.Add(8, 308);

        Console.WriteLine("\n - Percorrendo o dicionário: ");

        foreach (var item in dict3)
        {
            // Console.WriteLine(item);
            Console.WriteLine($"{item.Key} {item.Value}");
        }

        Console.WriteLine("\n - Ordenando os elementos do dicionário(SortedDictionary/LinQ) ");

        var dict3Ordenado = new SortedDictionary<int, int>(dict3);
        var dict3Ordenado2 = dict3.OrderBy(x => x.Key);


        foreach (var item in dict3Ordenado)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }

        Console.WriteLine("\n - OrderBy");
        foreach (var item in dict3Ordenado2)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }
    }
}