using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO3
{
    internal class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
        }

        public void Estudar()
        {
            Console.WriteLine($"{ Nome } está estudando...");
        }
    }
}
