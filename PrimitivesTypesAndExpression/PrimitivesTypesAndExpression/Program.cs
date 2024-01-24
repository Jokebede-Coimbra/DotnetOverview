internal class Program
{
    private static void Main(string[] args)
    {
        /*byte number = 23;
       int count = 10;
       float totalPrice = 20.96f;
       char character = 'J';
       string firstName = "Coimbra";
       bool isWorking = false;*/

        var number = 23;
        var count = 10;
        var totalPrice = 20.96f;
        var character = 'J';
        var firstName = "Coimbra";
        var isWorking = false;

        const float Pi = 3.14f;


        Console.WriteLine(number);
        Console.WriteLine(count);
        Console.WriteLine(totalPrice);
        Console.WriteLine(character);
        Console.WriteLine(firstName);
        Console.WriteLine(isWorking);


        // interpolação de string ou composição de string formatada

        Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
        Console.WriteLine($"{byte.MinValue} {byte.MaxValue}");

        Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        Console.WriteLine($"{float.MinValue} {float.MaxValue}");

    }
}