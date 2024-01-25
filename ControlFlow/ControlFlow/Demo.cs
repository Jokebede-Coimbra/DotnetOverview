internal class Program
{
    private static void Main(string[] args)
    {

        var i = 0;
        while (i <= 20)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);

            }
            i++;
        }

        //============Break==============
        while (true)
        {
            Console.WriteLine("Type your name: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                break;

            Console.WriteLine("@Echo: " + input);
        }
        //============Continue==============
        while (true)
        {
            Console.WriteLine("Type your name: ");
            var input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("@Echo: " + input);
                continue;
            }
            break;
        }

    }
}