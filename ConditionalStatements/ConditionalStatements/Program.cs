using ConditionalStatements;

internal class Program
{
    private static void Main(string[] args)
    {
        bool isGoldCustomer = true;

       /* 
        * float price;

        if (isGoldCustomer)
        {
            price = 19.95f;
        } else
        {
            price = 29.95f;
        }
        Console.WriteLine(price);
       */

        float price = (isGoldCustomer) ? 19.95f : 29.95f;
        Console.WriteLine(price);
        // ===============================================

        var season = Season.Autumn;

        switch (season)
        {
            case Season.Autumn:
                Console.WriteLine("It's autum and a beautiful season.");
                break;
            case Season.Summer:
                Console.WriteLine("It's perfect to go to beasch.");
                break;
            default:
                Console.WriteLine("I don't understand tha season!");
                break;


        }
    }
}