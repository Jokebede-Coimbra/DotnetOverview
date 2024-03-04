using OperadorIsEAs;

internal class Program
{
    private static void Main(string[] args)
    {
        Object carroObj = new Carro();
        Console.WriteLine("==============Sem usar o operador as==================");
        try
        {
            var x = (string)carroObj; // exception
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nA conversão falhou...\n");
            Console.WriteLine(ex.ToString());
        }

        Console.WriteLine("==============Usando o operador as==================");

        Object carroObj2 = new Carro();


        var y = carroObj2 as string;

        if (y != null)
        {
            Console.WriteLine("Converteu obj para string");
        }
        else
        {

            Console.WriteLine("\nNão foi possível converter, y é null");
        }

        

    }
}