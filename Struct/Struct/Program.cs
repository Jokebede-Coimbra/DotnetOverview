// See https://aka.ms/new-console-template for more information

Console.WriteLine("## Structs ##\n");

Cliente cliente = new();
cliente.Nome = "Jayanne";
cliente.Idade = 5;

Console.WriteLine($"{cliente.Nome} - {cliente.Idade} anos.");



public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
