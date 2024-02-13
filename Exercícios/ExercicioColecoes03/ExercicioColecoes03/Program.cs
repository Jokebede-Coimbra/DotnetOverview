using ExercicioColecoes03;
using System.Collections;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList list = new ArrayList();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            list.Add(new Pessoa()
            {
                Nome = nome,
                Idade = idade
            });
        }
        ListaPessoa(list);

        var pessoa1 = list.Add(new Pessoa() { Nome = "Ana", Idade = 22 });
        var pessoa2 = list.Add(new Pessoa() { Nome = "Diná", Idade = 21 });
        
        Console.WriteLine("Listando novos integrantes...");
        ListaPessoa(list);
        Console.WriteLine("Removendoo último integrante...");
        list.RemoveAt(list.Count -1);
        ListaPessoa(list);
    }

    static void ListaPessoa(ArrayList list)
    {
        foreach(Pessoa pessoa in list)
        {
            Console.WriteLine(pessoa.Exibir());
        }
    }
}
