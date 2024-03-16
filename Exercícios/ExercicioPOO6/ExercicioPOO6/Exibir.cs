using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO6
{
    internal class Exibir : INota1, INota2
    {
        void INota1.Classificacao()
        {
            Console.WriteLine("Classificacao INota1");
        }
        void INota2.Classificacao()
        {
            Console.WriteLine("Classificacao INota2");

        }
    }
}
