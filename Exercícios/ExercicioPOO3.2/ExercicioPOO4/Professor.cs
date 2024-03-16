using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO4
{
    internal class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
        }

        public void Explicar()
        {
            Console.WriteLine($"{Nome}, está explicando..");
        }
    }
}
