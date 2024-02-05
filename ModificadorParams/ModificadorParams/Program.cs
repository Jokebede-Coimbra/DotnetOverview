internal class Program
{
    private static void Main(string[] args)
    {
        int[] valores = { 1, 2, 3, 4, 5 };

        var resultado = Soma(valores);
        Console.WriteLine(resultado);

        var resultado2 = Soma(1, 2, 3, 4, 5, 1);
        Console.WriteLine(resultado2);


    }
    static int Soma(params int[] numeros)
    {
        int soma = 0;
        foreach (var numero in numeros)
            soma += numero;
        return soma;
    }
}