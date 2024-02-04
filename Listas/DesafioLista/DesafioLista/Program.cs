internal class Program
{
    private static void Main(string[] args)
    {
        /*
                // Desafio 1 e 2
                var numeros = new List<int>() { };

                // Desafio 3 e 4
                var pares = new List<int>();
                var impares = new List<int>();

                Console.WriteLine("Entre com 10 números: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Número: {i}");
                    int valor = int.Parse(Console.ReadLine());
                    if (valor % 2 == 0)
                    {
                        pares.Add(valor);

                    }
                    else
                    {
                        impares.Add(valor);
                    }
                }

                // Desafio 5
                Console.WriteLine("Listando Pares..");
                foreach (int valor in pares)
                    Console.WriteLine(valor);

                Console.WriteLine("Listando Impares..");
                foreach (int valor in impares)
                    Console.WriteLine(valor);

                */

        // Versão 2
        var n = new List<int>();
        List<int> par, imp;

        Console.WriteLine("Entre com 10 números: ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Número: {i}");
            int valor = int.Parse(Console.ReadLine());
            n.Add(valor);
        }

        ClassificarNumeros(n, out par, out imp);
        Console.WriteLine("Listando Pares:..");
        ExibirNumeros(par);

        Console.WriteLine("Listando impares:..");
        ExibirNumeros(imp);

        static void ClassificarNumeros(List<int> numeros, out List<int> pares, out List<int> impares)
        {
            pares = new List<int>();
            impares = new List<int>();

            foreach (var n in numeros)
            {
                if (n % 2 == 0)
                {
                    pares.Add(n);
                }
                else
                {
                    impares.Add(n);
                }
            }

        }

        static void ExibirNumeros(List<int> numeros)
        {
            foreach (int valor in numeros)
            {
                Console.WriteLine(valor);
            }

        }

    }
}
