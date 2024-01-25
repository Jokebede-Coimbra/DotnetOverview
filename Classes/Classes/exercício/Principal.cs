
using System.Globalization;
namespace Classes.exercício
{
    internal class Principal
    {
        private static void Run(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine());

            double salMedio = (funcionario1.Salario + funcionario2.Salario) / 2;

            Console.WriteLine("Salário médio: " + salMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}