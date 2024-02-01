using ExercicioLista;
using System;

internal class Program
{
    private static void Main(string[] args)
    {


        Console.WriteLine("How many employees will be registered? ");
        int quantidade = int.Parse(Console.ReadLine());

        List<Funcionario> lista = new List<Funcionario>();

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Emplyoee #{i}: ");
            Console.WriteLine("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Salary: ");
            double salario = double.Parse(Console.ReadLine());

            lista.Add(new Funcionario(id, nome, salario));
        }


        Console.WriteLine("Enter the employee id that will have salary increase: ");
        int idd = int.Parse(Console.ReadLine());

        Funcionario funcionario = lista.Find(x => x.Id == idd);

        if (funcionario != null)
        {
            Console.WriteLine("Enter the percentage:  ");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionario.AumentoSalario(porcentagem);

        }
        else
        {
            Console.WriteLine("Este ID não existe!");
        }


        Console.WriteLine("Updated list of employees:  ");
        foreach (Funcionario a in lista)
        {
            Console.WriteLine(a);
        }

    }
}