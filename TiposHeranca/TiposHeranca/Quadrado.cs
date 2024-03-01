using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposHeranca
{
    internal class Quadrado : Forma, ICusto
    {
        public int GetArea()
        {
            return (lado * lado);

        }

        public int GetCusto(int area)
        {
            return area * 10;
        }
    }
}
