internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("### Herança ##\n");

        Funcionario funcionario = new();
        funcionario.Nome = "Coimbra";
        funcionario.Email = "coimbra@gmail.com";
        funcionario.Empresa = "Apple Inc.";
        funcionario.Salario = 1000;

        Console.WriteLine("Funcionário");
        Console.WriteLine(funcionario.Empresa);
        Console.WriteLine(funcionario.Salario);
        funcionario.Identificar();

        Aluno aluno = new Aluno();
        aluno.Nome = "Coimbra";
        aluno.Email = "coimbra@gmail.com";
        aluno.Curso = "Arquiteta";
        aluno.Nota = 9;

        Console.WriteLine("\nAluno\n");
        Console.WriteLine(aluno.Curso);
        Console.WriteLine(aluno.Nota);
        funcionario.Identificar();

        Console.ReadLine();

    }
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public void Identificar()
        {
            Console.WriteLine($"{Nome} - {Email}");
        }

    }

    public class Funcionario : Pessoa
    {
        public string Empresa { get; set; }
        public decimal Salario { get; set; }
    }

    public class Aluno : Pessoa
    {
        public string Curso { get; set; }
        public int Nota { get; set; }
    }
}
