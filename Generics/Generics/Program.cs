using Generics;

internal class Program
{
    private static void Main(string[] args)
    {
        int a1 = 12;
        int a2 = 12;

        float f1 = 2;
        float f2 = 2;

        string s1 = "45";
        string s2 = "45";

        // Passando o tipo como parâmetro
        Compara<int, int> obj1 = new Compara<int, int>();
        obj1.ComparaTipo(a1, a2);

        // ou 
        var bj2 = new Compara<string, string>();
        bj2.ComparaTipo(s1, s2);

        var bj3 = new Compara<float, float>();
        bj3.ComparaTipo(f1, f2);


        
    }


}