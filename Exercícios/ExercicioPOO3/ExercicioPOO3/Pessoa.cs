using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO3
{
    internal class Pessoa
    {
        public string Nome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public override string? ToString()
        {
            return $"Olá! meu nome é {Nome}";
        }
    }
}
