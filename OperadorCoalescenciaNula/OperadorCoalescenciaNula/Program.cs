﻿internal class Program
{
    private static void Main(string[] args)
    {
        double? x = null;
        double? y = 20;

        double a = x ?? 5;
        double b = y ?? 5;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}