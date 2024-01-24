internal class Program
{
    private static void Main(string[] args)
    {
        var a = 10;
        var b = 3;
        var c = 5;

        Console.WriteLine(a / b); // 3
        Console.WriteLine((float)a / (float)b); // 3,333333
        Console.WriteLine(!(a != b));
        Console.WriteLine(c > b && c > a);
        Console.WriteLine(a < b || a == c);
        Console.WriteLine(!(b < c || c == a));
    }
}