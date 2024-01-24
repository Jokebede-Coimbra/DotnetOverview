internal class Program
{
    private static void Main(string[] args)
    {
        int i = 1;
        byte b = (byte) i;
        Console.WriteLine(b);

        float f = 1.0f;
        int c = (int)f;
        Console.WriteLine(c);


        var s = "1";

        int d = Convert.ToInt32(s);
        Console.WriteLine(d);

        int e = int.Parse(s);
        Console.WriteLine(e);
    }
}