internal class Program
{
    private static void Main(string[] args)
    {
        ClasseGenerica<int> objInt = new ClasseGenerica<int>();
        objInt.Adicionar(101);
        objInt.Adicionar(102);
        objInt.Adicionar(103);
        objInt.Adicionar(104);
        objInt.Adicionar(105);

        Console.WriteLine("Classe Genérica<T> de objeto int\n");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(objInt[i]);
        }
    }

    public class ClasseGenerica<T>
    {
        T[] obj = new T[5];
        int contador = 0;

        public void Adicionar(T item)
        {
            if (contador < 5)
            {
                obj[contador] = item;
            }
            contador++;
        }

        // indexador
        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }

    }
}