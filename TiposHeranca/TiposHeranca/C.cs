using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TiposHeranca
{
    internal class C : A
    {
        public void Apresentar()
        {
            Console.WriteLine("Método da classe C");

        }
    }
}
