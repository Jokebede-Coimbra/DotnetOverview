internal class Program
{
    delegate double Funcao(double a, double b);
    private static void Main(string[] args)
    {
        double resul;

        Funcao funcao = (CalculaMedia);
        resul = funcao(8.0, 4.0);

        Console.WriteLine($"Média: {resul}");

        funcao = (CalculaMultiplicacao);
        resul = funcao(2, 2);

        Console.WriteLine($"Multiplicação: {resul}");

        static double CalculaMedia(double n1, double n2)
        {
            return (n1 + n2) / 2;
        }

        static double CalculaMultiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }
    }
}