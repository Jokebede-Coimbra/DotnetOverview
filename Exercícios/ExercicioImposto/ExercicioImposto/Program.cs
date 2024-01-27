using ExercicioImposto;

internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario();

        Console.WriteLine("Nome: ");
        funcionario.Nome = Console.ReadLine();

        Console.WriteLine("Salário bruto: "); 
        funcionario.SalarioBruto = double.Parse(Console.ReadLine());

        Console.WriteLine("Imposto: ");
        funcionario.Imposto = double.Parse(Console.ReadLine());

        Console.WriteLine("Funcionário: " + funcionario);

        Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
        double porcentagem = double.Parse(Console.ReadLine());
        funcionario.AumentarSalario(porcentagem);

        Console.WriteLine("Dados atualizados: " + funcionario);
        



    }
}