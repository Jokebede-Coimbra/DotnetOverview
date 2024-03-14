using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO
{
    internal interface IVeiculo
    {
        void Dirigir() { }

        bool Abastecer(int qtdGasolina)
        {
            return false;
        }
    }
}
