using Indexadores;

internal class Program
{
    private static void Main(string[] args)
    {
        Time time = new Time();
        // get
        time[1] = "Azul";
        time[3] = "Rosa";
        time[5] = "Rosa";
        time[6] = "Rosa";
        time[8] = "Rosa";
        time[100] = "Rosa";

        // set

        string valor1 = time[1];
        string valor2 = time[3];
        string valor3 = time[5];
        string valor4 = time[6];
        string valor5 = time[8];
        string valor6 = time[100];

        Console.WriteLine(valor1);
        Console.WriteLine(valor2);
        Console.WriteLine(valor3);
        Console.WriteLine(valor4);
        Console.WriteLine(valor5);
        Console.WriteLine(valor6);

    }
}