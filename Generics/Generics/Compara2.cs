using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Compara2<tipoA, tipoB> where tipoA: class, new() where tipoB : IComparable { 
        public void ComparaTipo2(tipoA p1, tipoB p2)
        {
            bool result;
            result = p1.Equals(p2);
            Console.WriteLine($"Os parâmentrossão iguais? {result}");
        }
    }
}
