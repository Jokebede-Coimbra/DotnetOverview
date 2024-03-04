using Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {

        IControle demo = new Demo();
        demo.Nome = "Teste Demo";
        demo.Desenhar();
        demo.Exibir();
    }
}