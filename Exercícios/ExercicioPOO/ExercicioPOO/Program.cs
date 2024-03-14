using ExercicioPOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Carro carro = new Carro(0);
       
        Console.WriteLine("Informe a quantidade da gasolina: ");
        int gasolina = Convert.ToInt32(Console.ReadLine());

        if (carro.Abastecer(gasolina))
        {
            carro.Dirigir();
        }

       

    }
}