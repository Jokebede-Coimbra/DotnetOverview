using HerancaDowncastingUpcasting;

internal class Program
{
    private static void Main(string[] args)
    {
        Circulo circulo = new Circulo(20, 20); 
        Forma f = circulo; // UPCASTING

        Circulo c = (Circulo)f; // DOWNCASTING

        c.Desenhar();
        c.PintarCirculo();

        Console.WriteLine(c == f);
        Console.WriteLine(c == circulo);

       


    }
}