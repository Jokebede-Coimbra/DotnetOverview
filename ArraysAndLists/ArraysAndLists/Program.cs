using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=========Arrays=======");
        // int[] numbers = new int[] { 1, 2, 3 };
        // ou
        var numbers = new[] { 1, 2, 3, 4, 50, 10, 25, 36 };
        // Length
        Console.WriteLine("Length: " + numbers.Length);

        // IndexOf()
        var index = Array.IndexOf(numbers, 2);
        Console.WriteLine("Index of 9: " + index);

        // Clear()
        Array.Clear(numbers, 0, 2); // 0 0 3 4 10 25 36
        Console.WriteLine("Effect of Clear(): ");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Copy()
        int[] another = new int[3];
        Array.Copy(numbers, another, 3);

        Console.WriteLine("Effect of Copy()");
        foreach (var number in another)
            Console.WriteLine(number);

        // Sort()
        Array.Sort(numbers);

        Console.WriteLine("Effect of Sort()");
        foreach (var number in numbers)
            Console.WriteLine(number);

        // Reverse()
        Array.Reverse(numbers);

        Console.WriteLine("Effect of Reverse()");
        foreach (var number in numbers)
            Console.WriteLine(number);

        Console.WriteLine();
        // =====================================================
        Console.WriteLine("=========Lists=========");
        var nums = new List<int>() { 2, 5, 8, 66, 12 };
        nums.Add(1);
        nums.AddRange(new int[2] { 13, 14 });

        foreach (var n in nums)
            Console.WriteLine(n);

        Console.WriteLine();
        Console.WriteLine("Index of 1: " + nums.IndexOf(8));
        Console.WriteLine("Last Index of 1: " + nums.LastIndexOf(5));

        Console.WriteLine("Count: " + nums.Count);

        nums.Remove(5);
        foreach (var r in nums)
            Console.WriteLine(r);

        Console.WriteLine();

        for (var i = 0; i < nums.Count; i++)
        {
            if (nums[i] == 66)
                nums.Remove(nums[i]);
        }

        foreach (var n in nums)
            Console.WriteLine(n);

        Console.WriteLine();

        nums.Clear();
        Console.WriteLine("Count: " + nums.Count);
    }
}