using ExercicioPOO5;

internal class Program
{
    private static void Main(string[] args)
    {
        Database data = new SQLServe();
        data.Configurar();
        data.Conectar();
    }
}