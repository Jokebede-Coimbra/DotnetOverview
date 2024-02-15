using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        var gato = new Gato() { Nome = "Bolinha" };
        gato.ExibeNome();

        var cachorro = new Cachorro() { Nome = "Pepita" };
        cachorro.ExibeNome();
    }
    // Classe base
    class Animal
    {
        public string Nome { get; set; }
        public virtual void ExibeNome()
        {
            Console.WriteLine($"\nMeu nome é {Nome}");
        }
    }
    // Classe derivada
    class Gato : Animal
    {

        public override void ExibeNome()
        {
            Console.WriteLine($"\nEu sou um gato. Meu nome é {Nome}");
        }
    }  
    // Classe derivada
    class Cachorro : Animal
    {

        
    }
}



