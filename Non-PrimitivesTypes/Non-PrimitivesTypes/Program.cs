internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Declaring Arrays");

        int[] numbers = new int[4];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        // ==========================
        var flags = new bool[3];
        flags[0] = true;
        flags[1] = true;

        Console.WriteLine(flags[0]);
        Console.WriteLine(flags[1]);
        Console.WriteLine(flags[2]);

        // ==========================
        var names = new string[3] {"Coimbra", "Maria", "João"};
        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);
    }
}