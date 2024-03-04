using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IControle
    {
        string Nome { get; set; }
        void Desenhar();

        public void Exibir()
        {
            Console.WriteLine("Exibindoo..");
        }
    }
}
