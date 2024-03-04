using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Demo : IControle, IGrafico
    {
        public string Nome { get; set; } = string.Empty;

        public void Desenhar()
        {
            Console.WriteLine("Desenhando..");
        }

        public void Pintar()
        {
            Console.WriteLine("Pintando..");
        }
    }
}
