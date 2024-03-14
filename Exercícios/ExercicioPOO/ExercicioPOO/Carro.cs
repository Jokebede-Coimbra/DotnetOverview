using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    internal class Carro : IVeiculo
    {
        public int QuantidadeInicialGasolina { get; set; }

        public Carro(int quantidadeInicialGasolina)
        {
            QuantidadeInicialGasolina = quantidadeInicialGasolina;
        }

        public void Dirigir()
        {
            if (QuantidadeInicialGasolina > 0)
            {
                Console.WriteLine("Dirigindo o carro...");
            }
            else
            {
                Console.WriteLine("Sem gasolina...");
            }
        }

        public bool Abastecer(int qtdGasolina)
        {
            QuantidadeInicialGasolina += qtdGasolina;
            return true;
        }
    }
}
